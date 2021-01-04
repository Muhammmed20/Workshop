using System;
using System.IO;
using Workshop.DI.MicrosoftExtension.Resolver;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using Workshop.DI.MicrosoftExtension.Logic.Abstract;
using Workshop.DI.MicrosoftExtension.Logic.Concrete;

//using System.ComponentModel;

namespace Workshop.DI.MicrosoftExtension
{
    internal class Program
    {
        private static void Main()
        {
            //Container.Todo();

            var builder = new ConfigurationBuilder();
            BuildConfig(builder);

            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(builder.Build())
                .Enrich.FromLogContext()
                .WriteTo.Console()
                .CreateLogger();

            Log.Logger.Information("Application Starting");

            var host = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddTransient<IBar, Bar>();
                    services.AddTransient<IFoo, Foo>();
                })
                .UseSerilog()
                .Build();

            var bar = ActivatorUtilities.CreateInstance<Bar>(host.Services);
            bar.RunBar();
        }

        static void BuildConfig(IConfigurationBuilder builder)
        {
            builder.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production"}.json", optional: true)
                .AddEnvironmentVariables();
        }
    }
}