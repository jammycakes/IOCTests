using System;
using Microsoft.Extensions.DependencyInjection;
using Rezolver;

namespace IOCTests
{
    public class RezolverTests : TestBase
    {
        protected override IServiceProvider CreateServiceProvider(IServiceCollection serviceCollection)
        {
            return serviceCollection.CreateRezolverContainer();
        }
    }
}