using System;
using Autofac;

namespace Workshop.DI.AutofacAttribute.Autofac.RegistrationTypes
{
    public class InstancePerHttpRequest : RegistrationAttribute
    {
        internal override void Register(ContainerBuilder builder, Type type)
        {
            var registrationBuilder = builder.RegisterType(type)
                .InstancePerMatchingLifetimeScope("AutofacWebRequest");

            Register(registrationBuilder, type);
        }
    }
}