using Workshop.DI.AutofacAttribute.Utilities.Autofac.Classifiers.Abstract;
using Workshop.DI.AutofacAttribute.Utilities.Autofac.Instances;

namespace Workshop.DI.AutofacAttribute.Utilities.Autofac.Classifiers.Concrete
{
    [InstanceSingleScope(AsImplementedInterface = false)]
    public class ConcreteTypeRegistration : IConcreteTypeRegistration
    {
    }
}