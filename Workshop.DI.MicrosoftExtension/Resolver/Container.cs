using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Workshop.DI.MicrosoftExtension.Logic.Abstract;
using Workshop.DI.MicrosoftExtension.Logic.Concrete;

namespace Workshop.DI.MicrosoftExtension.Resolver
{
    public static class Container
    {
        public static void Todo()
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IFoo, Foo>()
                .AddTransient<IBar, Bar>()
                .BuildServiceProvider();

            var logger = serviceProvider.GetService<ILoggerFactory>()
                .CreateLogger<Program>();
            logger.LogDebug("Starting application");

            //do the actual work here
            var bar = serviceProvider.GetService<IBar>();
            bar.RunBar();

            logger.LogDebug("All done!");
        }
    }
}