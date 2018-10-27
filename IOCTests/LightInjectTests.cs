using System;
using LightInject.Microsoft.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace IOCTests
{
    public class LightInjectTests : TestBase

    {
        protected override IServiceProvider CreateServiceProvider(IServiceCollection serviceCollection)
        {
            var container = new LightInject.ServiceContainer();
            return container.CreateServiceProvider(serviceCollection);
        }
    }
}