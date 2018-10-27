using System;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace IOCTests
{
    public class AutofacTests : TestBase
    {
        protected override IServiceProvider CreateServiceProvider(IServiceCollection serviceCollection)
        {
            var factory = new AutofacServiceProviderFactory();
            var builder = factory.CreateBuilder(serviceCollection);
            return factory.CreateServiceProvider(builder);
        }
    }
}