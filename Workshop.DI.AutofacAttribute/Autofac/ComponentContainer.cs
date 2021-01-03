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
            var a = AppDomain.CurrentDomain.GetAssemblies();
            builder.RegisterAssemblyTypes(AppDomain.CurrentDomain.GetAssemblies())
                .Where(t => t.GetCustomAttribute<ComponentAttribute>() != null)
                .AsImplementedInterfaces();

            return builder.Build();
        }
    }
}