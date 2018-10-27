using System;
using Maestro.Microsoft.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;


namespace IOCTests
{
    public class MaestroTests : TestBase
    {
        protected override IServiceProvider CreateServiceProvider(IServiceCollection serviceCollection)
        {
            var factory = new MaestroServiceProviderFactory();
            var builder = factory.CreateBuilder(serviceCollection);
            return factory.CreateServiceProvider(builder);
        }
    }
}