using Workshop.DI.AutofacAttribute.Autofac.RegistrationTypes;
using Workshop.DI.AutofacAttribute.Autofac.SampleUsages.Abstract;

namespace Workshop.DI.AutofacAttribute.Autofac.SampleUsages.Concrete
{
    [InstancePerDependency]
    public class InstancePerDependencyClass : IInstancePerDependency
    {
    }
}