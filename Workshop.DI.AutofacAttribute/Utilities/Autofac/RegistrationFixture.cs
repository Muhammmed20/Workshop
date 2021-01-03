using Autofac;
using Workshop.DI.AutofacAttribute.Utilities.Autofac.Classifiers.Abstract;

namespace Workshop.DI.AutofacAttribute.Utilities.Autofac
{
    public class RegistrationFixture
    {
        protected IContainer Container;

        protected void GivenTheContainerIsBuilt()
        {
            //var builder = new ContainerBuilder();
            //builder.RegisterByAttributes(typeof(ISingleInstance).Assembly);
            //Container = builder.Build();
        }
    }
}