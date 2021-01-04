using Workshop.DI.AutofacAttribute.Autofac.SampleUsages.Abstract;

namespace Workshop.DI.AutofacAttribute.Autofac.SampleUsages.Concrete
{
    [InstanceSingleScope(AsImplementedInterface = false)]
    [InstanceSingleScope(Name = "Test", AsImplementedInterface = false)]
    public class MultiRegistration : IMultiRegistration
    {
    }
}