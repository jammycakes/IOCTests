using System;
using Castle.Windsor;
using Castle.Windsor.MsDependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace IOCTests
{
    public class WindsorTests : TestBase
    {
        protected override IServiceProvider CreateServiceProvider(IServiceCollection serviceCollection)
        {
            return WindsorRegistrationHelper.CreateServiceProvider(new WindsorContainer(), serviceCollection);
        }
    }
}