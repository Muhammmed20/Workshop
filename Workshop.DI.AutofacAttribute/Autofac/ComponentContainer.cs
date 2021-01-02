using Autofac;
using System.Linq;
using System.Reflection;

namespace Workshop.DI.AutofacAttribute.Autofac
{
    public static class ComponentContainer
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            //builder.RegisterAssemblyTypes(Assembly.Load(nameof(ExternalProjectName)))
            //    .Where(t => t.Namespace != null && t.Namespace.Contains("Utilities"))
            //    .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));

            return builder.Build();
        }
    }
}