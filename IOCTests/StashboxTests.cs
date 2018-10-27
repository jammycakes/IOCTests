using System;
using Microsoft.Extensions.DependencyInjection;

namespace IOCTests
{
    public class StashboxTests : TestBase
    {
        protected override IServiceProvider CreateServiceProvider(IServiceCollection serviceCollection)
        {
            return serviceCollection.UseStashbox();
        }
    }
}