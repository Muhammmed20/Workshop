using Autofac;
using Workshop.DI.AutofacAttribute.Autofac.SampleUsages.Concrete;

namespace Workshop.DI.AutofacAttribute.Autofac.SampleUsages
{
    public class MultiRegistrationFixture : RegistrationFixture
    {
        public void RunFixture()
        {
            var result = Container.ResolveOptional<MultiRegistration>();
        }
    }
}