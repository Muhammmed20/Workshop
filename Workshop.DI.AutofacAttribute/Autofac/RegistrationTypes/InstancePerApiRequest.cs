using System;
using Autofac;

namespace Workshop.DI.AutofacAttribute.Autofac.RegistrationTypes
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
}