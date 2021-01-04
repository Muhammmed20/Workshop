using System;

namespace Workshop.DI.AutofacAttribute.Autofac
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class ComponentAttribute : Attribute, IDependencyComponent
    {
    }
}