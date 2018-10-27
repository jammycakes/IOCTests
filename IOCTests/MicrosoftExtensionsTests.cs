using System;
using Microsoft.Extensions.DependencyInjection;

namespace IOCTests
{
    public class MicrosoftExtensionsTests : TestBase
    {
        protected override IServiceProvider CreateServiceProvider(IServiceCollection serviceCollection)
        {
            return serviceCollection.BuildServiceProvider();
        }
    }
}