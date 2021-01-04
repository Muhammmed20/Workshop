using System;
using Autofac;

namespace Workshop.DI.AutofacAttribute.Autofac
{
    public class InstancePerApiRequest : RegistrationAttribute, IDependencyComponent
    {
        internal override void Register(ContainerBuilder builder, Type type)
        {
            var registrationBuilder = builder.RegisterType(type)
                .InstancePerMatchingLifetimeScope("AutofacWebRequest");

            Register(registrationBuilder, type);
        }
    }

    public class InstancePerDependency : RegistrationAttribute, IDependencyComponent
    {
        internal override void Register(ContainerBuilder builder, Type type)
        {
            var registrationBuilder = builder.RegisterType(type)
                .InstancePerDependency();

            Register(registrationBuilder, type);
        }
    }

    public class InstancePerHttpRequest : RegistrationAttribute, IDependencyComponent
    {
        internal override void Register(ContainerBuilder builder, Type type)
        {
            var registrationBuilder = builder.RegisterType(type)
                .InstancePerMatchingLifetimeScope("AutofacWebRequest");

            Register(registrationBuilder, type);
        }
    }

    public class InstancePerLifetimeScope : RegistrationAttribute, IDependencyComponent
    {
        internal override void Register(ContainerBuilder builder, Type type)
        {
            var registrationBuilder = builder.RegisterType(type)
                .InstancePerLifetimeScope();

            Register(registrationBuilder, type);
        }
    }

    public class InstanceSingleScope : RegistrationAttribute, IDependencyComponent
    {
        internal override void Register(ContainerBuilder builder, Type type)
        {
            var registrationBuilder = builder.RegisterType(type)
                .SingleInstance();

            Register(registrationBuilder, type);
        }
    }
}