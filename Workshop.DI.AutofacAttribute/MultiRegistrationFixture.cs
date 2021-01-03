using Autofac;
using Workshop.DI.AutofacAttribute.Utilities.Autofac;
using Workshop.DI.AutofacAttribute.Utilities.Autofac.Classifiers.Concrete;

namespace Workshop.DI.AutofacAttribute
{
    public class MultiRegistrationFixture : RegistrationFixture
    {
        public void RunFixture()
        {
            var result = Container.ResolveOptional<MultiRegistration>();
        }
    }
}