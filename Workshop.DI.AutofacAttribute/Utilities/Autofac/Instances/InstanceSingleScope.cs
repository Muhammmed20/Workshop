using System;
using Autofac;

namespace Workshop.DI.AutofacAttribute.Utilities.Autofac.Instances
{
    public class InstanceSingleScope : AutofacRegistrationAttribute
    {
        internal override void Register(ContainerBuilder builder, Type type)
        {
            var registrationBuilder = builder.RegisterType(type)
                .SingleInstance();

            Register(registrationBuilder, type);
        }
    }
}