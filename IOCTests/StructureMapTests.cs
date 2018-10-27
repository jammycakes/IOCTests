using System;
using Microsoft.Extensions.DependencyInjection;
using StructureMap;

namespace IOCTests
{
    public class StructureMapTests : TestBase
    {
        protected override IServiceProvider CreateServiceProvider(IServiceCollection serviceCollection)
        {
            var container = new Container();
            container.Populate(serviceCollection);
            return container.GetInstance<IServiceProvider>();
        }
    }
}