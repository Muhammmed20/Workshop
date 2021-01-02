using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Loader;
using Autofac;
using Autofac.Configuration;
using Microsoft.Extensions.Configuration;

namespace Workshop.DI.AutofacConfiguration
{
    internal class Program
    {
        private static void Main()
        {
            var execFolder = Path.GetDirectoryName(typeof(Program).Assembly.Location);

            AssemblyLoadContext.Default.Resolving += (context, assembly) =>
                context.LoadFromAssemblyPath(Path.Combine(execFolder!, $"{assembly.Name}.dll"));

            var config = new ConfigurationBuilder()
                .AddJsonFile("autofac_config.json").Build();

            var configModule = new ConfigurationModule(config);

            var builder = new ContainerBuilder();
            builder.RegisterModule(configModule);

            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var component = scope.Resolve<ComponentA>();
                Console.WriteLine("Resolved component type: {0}", component.Name);

                Console.WriteLine("All available components:");
                var allComponents = scope.Resolve<IEnumerable<IComponent>>();
                foreach (var resolvedComponent in allComponents)
                {
                    Console.WriteLine("- {0}", resolvedComponent.Name);
                }
            }



            // exit:
            Console.ReadKey();
        }
    }
}