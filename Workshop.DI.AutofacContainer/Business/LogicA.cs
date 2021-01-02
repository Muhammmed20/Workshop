using System;
using Workshop.DI.AutofacContainer.Domain;
using Workshop.DI.AutofacContainer.Utilities;

namespace Workshop.DI.AutofacContainer.Business
{
    public class LogicA : ILogic
    {
        private readonly ILogger _logger;
        private readonly IDataAccess _dataAccess;

        public LogicA(ILogger logger, IDataAccess dataAccess)
        {
            _logger = logger;
            _dataAccess = dataAccess;
        }

        public void ProcessData()
        {
            _logger.Log("Process started.");
            Console.WriteLine("Processing..");

            _dataAccess.LoadData();
            _dataAccess.SaveData("ProcessedInfo");

            _logger.Log("Process finished.");
        }
    }
}