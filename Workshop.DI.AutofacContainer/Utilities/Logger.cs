using System;

namespace Workshop.DI.AutofacContainer.Utilities
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Logging { message }");
        }
    }
}