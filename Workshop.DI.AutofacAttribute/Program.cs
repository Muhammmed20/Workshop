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
            using (var container = ComponentContainer.Configure())
            {
                var client = container.Resolve<IClient>();
                client.Request();
            }


            // exit:
            Console.ReadKey();
        }
    }
}