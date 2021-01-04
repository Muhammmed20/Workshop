using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Workshop.DI.MicrosoftExtension.Logic.Abstract;

namespace Workshop.DI.MicrosoftExtension.Logic.Concrete
{
    public class Bar : IBar
    {
        private readonly ILogger<Bar> _logger;
        private readonly IConfiguration _config;

        private readonly IFoo _foo;

        public Bar(ILogger<Bar> logger, IConfiguration config, IFoo foo)
        {
            _logger = logger;
            _config = config;
            _foo = foo;
        }
        public void RunBar()
        {
            for (var i = 0; i < _config.GetValue<int>("LoopTimes"); i++)
            {
                _logger.LogError("Bar number {runNumber}", i);
                _foo.RunFoo(i);
            }
        }
    }
}