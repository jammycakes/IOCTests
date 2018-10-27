using System;
using Microsoft.Extensions.DependencyInjection;
using Unity;
using Unity.Microsoft.DependencyInjection;

namespace IOCTests
{
    public class UnityTests : TestBase
    {
        protected override IServiceProvider CreateServiceProvider(IServiceCollection serviceCollection)
        {
            return Unity.Microsoft.DependencyInjection.ServiceProviderExtensions.BuildServiceProvider(serviceCollection);
        }
    }
}