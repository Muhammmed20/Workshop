using System;
using Autofac;

namespace Workshop.DI.AutofacAttribute.Autofac.RegistrationTypes
{
    public class InstancePerLifetimeScope : RegistrationAttribute, IDependencyComponent
    {
        internal override void Register(ContainerBuilder builder, Type type)
        {
            var registrationBuilder = builder.RegisterType(type)
                .InstancePerLifetimeScope();

            Register(registrationBuilder, type);
        }
    }
}