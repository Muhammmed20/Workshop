using Autofac;
using System.Linq;
using System.Reflection;
using Workshop.DI.AutofacContainer.Business;

namespace Workshop.DI.AutofacContainer.Facade.Autofac
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            //builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<LogicB>().As<ILogic>();

            builder.RegisterAssemblyTypes(Assembly.Load(nameof(Workshop.DI.AutofacContainer)))
                .Where(t => t.Namespace != null && t.Namespace.Contains("Utilities"))
                .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));

            builder.RegisterAssemblyTypes(Assembly.Load(nameof(Workshop.DI.AutofacContainer)))
                .Where(t => t.Namespace != null && t.Namespace.Contains("Domain"))
                .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));

            builder.RegisterAssemblyTypes(Assembly.Load(nameof(Workshop.DI.AutofacContainer)))
                .Where(t => t.Namespace != null && t.Namespace.Contains("Facade"))
                .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));

            return builder.Build();
        }
    }
}