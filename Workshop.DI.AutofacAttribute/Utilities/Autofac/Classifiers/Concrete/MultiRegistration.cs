using Workshop.DI.AutofacAttribute.Autofac.RegistrationTypes;
using Workshop.DI.AutofacAttribute.Utilities.Autofac.Classifiers.Abstract;

namespace Workshop.DI.AutofacAttribute.Utilities.Autofac.Classifiers.Concrete
{
    //[InstanceSingleScope(AsImplementedInterface = false)]
    [InstanceSingleScope(Name = "Test", AsImplementedInterface = false)]
    public class MultiRegistration : IMultiRegistration
    {
    }
}