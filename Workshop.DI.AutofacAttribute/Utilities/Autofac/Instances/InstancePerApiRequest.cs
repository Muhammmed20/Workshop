using System;
using Autofac;

namespace Workshop.DI.AutofacAttribute.Utilities.Autofac.Instances
{
    public class InstancePerApiRequest : AutofacRegistrationAttribute
    {
        internal override void Register(ContainerBuilder builder, Type type)
        {
            var registrationBuilder = builder.RegisterType(type)
                .InstancePerMatchingLifetimeScope("AutofacWebRequest");

            Register(registrationBuilder, type);
        }
    }
}