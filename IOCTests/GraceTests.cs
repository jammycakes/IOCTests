using System;
using Grace.DependencyInjection.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace IOCTests
{
    public class GraceTests : TestBase
    {
        protected override IServiceProvider CreateServiceProvider(IServiceCollection serviceCollection)
        {
            var container = new Grace.DependencyInjection.DependencyInjectionContainer();
            container.Populate(serviceCollection);
            return container.Locate<IServiceProvider>();
        }
    }
}