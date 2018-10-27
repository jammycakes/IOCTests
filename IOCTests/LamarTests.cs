using System;
using Microsoft.Extensions.DependencyInjection;

namespace IOCTests
{
    public class LamarTests : TestBase
    {
        protected override IServiceProvider CreateServiceProvider(IServiceCollection serviceCollection)
        {
            return new Lamar.Container(serviceCollection);
        }
    }
}