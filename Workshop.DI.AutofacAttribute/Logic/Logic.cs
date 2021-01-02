using System;
using Workshop.DI.AutofacAttribute.Autofac;
using Workshop.DI.AutofacAttribute.Domain;

namespace Workshop.DI.AutofacAttribute.Logic
{
    [Component]
    public class Logic : ILogic
    {
        private readonly IDataAccess _dataAccess;

        public Logic(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public void ProcessData()
        {
            _dataAccess.LoadData();
            Console.WriteLine("data processed.");
        }
    }
}