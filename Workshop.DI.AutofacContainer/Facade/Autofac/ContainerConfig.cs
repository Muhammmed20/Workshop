using Autofac;
using System.Linq;
using System.Reflection;
using Workshop.DI.AutofacContainer.Business;
using Workshop.DI.AutofacContainer.Domain;
using Workshop.DI.AutofacContainer.Utilities;

namespace Workshop.DI.AutofacContainer.Facade.Autofac
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Logger>().As<ILogger>();
            builder.RegisterType<DataAccess>().As<IDataAccess>();
            builder.RegisterType<LogicB>().As<ILogic>();
            builder.RegisterType<Application>().As<IApplication>();

            //builder.RegisterAssemblyTypes(Assembly.Load(nameof(ExternalProjectName)))
            //    .Where(t => t.Namespace != null && t.Namespace.Contains("Utilities"))
            //    .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));

            return builder.Build();
        }
    }
}