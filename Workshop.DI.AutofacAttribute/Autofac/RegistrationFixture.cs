using Autofac;

namespace Workshop.DI.AutofacAttribute.Autofac
{
    public class RegistrationFixture
    {
        protected IContainer Container;

        protected void BuildContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterByAttributes(typeof(IDependencyComponent).Assembly);
            Container = builder.Build();
        }
    }
}