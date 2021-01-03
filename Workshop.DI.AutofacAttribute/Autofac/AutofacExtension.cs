using System.Linq;
using System.Reflection;
using Autofac;

namespace Workshop.DI.AutofacAttribute.Autofac
{
    public static class AutofacExtension
    {
        public static void RegisterByAttributes(this ContainerBuilder builder, params Assembly[] assemblies)
        {
            var registrations = from assembly in assemblies
                from type in assembly.GetTypes()
                from attribute in type.GetCustomAttributes(false)
                where attribute is RegistrationAttribute
                select new
                {
                    Attribute = (RegistrationAttribute)attribute,
                    Type = type
                };


            foreach (var registration in registrations)
            {
                registration.Attribute.Register(builder, registration.Type);
            }
        }
    }
}