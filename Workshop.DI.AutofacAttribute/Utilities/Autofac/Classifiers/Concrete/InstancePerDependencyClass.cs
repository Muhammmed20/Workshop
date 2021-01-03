using Workshop.DI.AutofacAttribute.Autofac.RegistrationTypes;
using Workshop.DI.AutofacAttribute.Utilities.Autofac.Classifiers.Abstract;

namespace Workshop.DI.AutofacAttribute.Utilities.Autofac.Classifiers.Concrete
{
    [InstancePerDependency]
    public class InstancePerDependencyClass : IInstancePerDependency
    {
    }
}