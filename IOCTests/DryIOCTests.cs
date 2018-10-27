using System;
using DryIoc;
using DryIoc.Microsoft.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace IOCTests
{
    public class DryIOCTests : TestBase
    {
        protected override IServiceProvider CreateServiceProvider(IServiceCollection serviceCollection)
        {
            var container = new Container();
            return container.WithDependencyInjectionAdapter(serviceCollection).BuildServiceProvider();
        }
    }
}