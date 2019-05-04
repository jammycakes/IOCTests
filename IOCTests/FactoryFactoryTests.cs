using System;
using FactoryFactory;
using Microsoft.Extensions.DependencyInjection;

namespace IOCTests
{
    public class FactoryFactoryTests : TestBase
    {
        protected override IServiceProvider CreateServiceProvider(IServiceCollection serviceCollection)
        {
            return serviceCollection.CreateFactoryFactory();
        }
    }
}