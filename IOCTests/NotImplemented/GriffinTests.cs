using System;
using Microsoft.Extensions.DependencyInjection;

namespace IOCTests.NotImplemented
{
    public class GriffinTests : TestBase
    {
        protected override IServiceProvider CreateServiceProvider(IServiceCollection serviceCollection)
        {
            throw new NotImplementedException();
        }
    }
}