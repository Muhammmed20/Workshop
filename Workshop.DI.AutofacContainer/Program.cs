using System;
using Autofac;
using Workshop.DI.AutofacContainer.Facade;
using Workshop.DI.AutofacContainer.Facade.Autofac;

namespace Workshop.DI.AutofacContainer
{
    internal class Program
    {
        private static void Main()
        {
            var container = ContainerConfig.Configure();

            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();
                app.Run();
            }



            // exit:
            Console.ReadKey();
        }
    }
}