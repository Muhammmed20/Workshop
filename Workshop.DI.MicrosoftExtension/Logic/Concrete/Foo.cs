using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Workshop.DI.MicrosoftExtension.Logic.Abstract;

namespace Workshop.DI.MicrosoftExtension.Logic.Concrete
{
    public class Foo : IFoo
    {
        private readonly ILogger<Foo> _logger;
        private readonly IConfiguration _config;
        public Foo(ILogger<Foo> logger, IConfiguration config)
        {
            _logger = logger;
            _config = config;
        }
        public void RunFoo(int number)
        {
            for (var i = 0; i < _config.GetValue<int>("LoopTimes"); i++)
            {
                _logger.LogError("Foo number {runNumber}", i);
            }
        }
    }
}