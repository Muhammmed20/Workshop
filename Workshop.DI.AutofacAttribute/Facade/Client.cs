using System;
using Workshop.DI.AutofacAttribute.Autofac;
using Workshop.DI.AutofacAttribute.Logic;

namespace Workshop.DI.AutofacAttribute.Facade
{
    [Component]
    public class Client : IClient
    {
        private readonly ILogic _logic;

        public Client(ILogic logic)
        {
            _logic = logic;
        }

        public void Request()
        {
            _logic.ProcessData();
            Console.WriteLine("client requested.");
        }
    }
}