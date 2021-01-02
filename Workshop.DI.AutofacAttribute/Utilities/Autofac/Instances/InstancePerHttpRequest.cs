using System;
using Autofac;

namespace Workshop.DI.AutofacAttribute.Utilities.Autofac.Instances
{
    public class InstancePerHttpRequest : AutofacRegistrationAttribute
    {
        internal override void Register(ContainerBuilder builder, Type type)
        {
            var registrationBuilder = builder.RegisterType(type)
                .InstancePerMatchingLifetimeScope("AutofacWebRequest");

            Register(registrationBuilder, type);
        }
    }
}