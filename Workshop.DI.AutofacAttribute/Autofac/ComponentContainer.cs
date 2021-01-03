using System;
using Autofac;
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


            builder.RegisterAssemblyTypes(AppDomain.CurrentDomain.GetAssemblies())
                .Where(t => t.GetCustomAttribute<ComponentAttribute>() != null)
                .AsImplementedInterfaces()/*.InstancePerRequest()*/;

            return builder.Build();
        }
    }
}