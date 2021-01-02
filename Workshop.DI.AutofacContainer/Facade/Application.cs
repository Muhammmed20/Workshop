using Workshop.DI.AutofacContainer.Business;

namespace Workshop.DI.AutofacContainer.Facade
{
    public class Application : IApplication
    {
        private readonly ILogic _logic;

        public Application(ILogic logic)
        {
            _logic = logic;
        }

        public void Run()
        {
            _logic.ProcessData();
        }
    }
}