using Autofac;
using Workshop.DI.AutofacAttribute.Utilities.Autofac;

namespace Workshop.DI.AutofacAttribute.Autofac
{
    public class RegistrationFixture
    {
        protected IContainer Container;

        protected void GivenTheContainerIsBuilt()
        {
            var builder = new ContainerBuilder();
            builder.RegisterByAttributes(typeof(IDependencyComponent).Assembly);
            Container = builder.Build();
        }
    }
}