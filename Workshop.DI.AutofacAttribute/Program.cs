using System;
using Autofac;
using Workshop.DI.AutofacAttribute.Autofac;
using Workshop.DI.AutofacAttribute.Facade;

namespace Workshop.DI.AutofacAttribute
{
    internal class Program
    {
        private static void Main()
        {
            var container = ComponentContainer.Configure();

            using (var scope = container.BeginLifetimeScope())
            {
                var client = scope.Resolve<IClient>();
                client.Request();
            }



            // exit:
            Console.ReadKey();
        }
    }
}