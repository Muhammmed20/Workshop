using System;
using Workshop.DI.AutofacAttribute.Autofac;

namespace Workshop.DI.AutofacAttribute.Domain
{
    [Component]
    public class DataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("data loaded.");
        }
    }
}