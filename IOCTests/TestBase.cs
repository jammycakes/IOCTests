#define OTHER_TESTS
// #define TEST_FUNC_AND_LAZY

using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Specification;
using Xunit;

namespace IOCTests
{
    public abstract class TestBase : DependencyInjectionSpecificationTests
    {
#if OTHER_TESTS
        public class TestServiceCollection : List<ServiceDescriptor>, IServiceCollection
        {
            public TestServiceCollection()
            {
                this.AddTransient<FuncService>();
                this.AddTransient<LazyService>();
                this.AddTransient<Dependency>();
                this.AddTransient<ServiceA>();
                this.AddTransient<ServiceB>();
                this.AddTransient<DualService>();
            }
        }

#if TEST_FUNC_AND_LAZY
        [Fact]
        public void CanCreateFuncDependency()
        {
            var serviceProvider = CreateServiceProvider(new TestServiceCollection());
            var service = serviceProvider.GetService<FuncService>();
            Assert.IsType<Dependency>(service.Dependency);
        }

        [Fact]
        public void CanCreateLazyDependency()
        {
            var serviceProvider = CreateServiceProvider(new TestServiceCollection());
            var service = serviceProvider.GetService<LazyService>();
            Assert.IsType<Dependency>(service.Dependency);
        }
#endif

        [Fact]
        public void InjectedTransientServicesAreDifferent()
        {
            var serviceProvider = CreateServiceProvider(new TestServiceCollection());
            var service = serviceProvider.GetService<DualService>();
            Assert.NotSame(service.ServiceA.Dependency, service.ServiceB.Dependency);
        }

        [Fact]
        public void CanCreateEmptyEnumerableDependency()
        {
            var serviceCollection = new TestServiceCollection();
            serviceCollection.AddTransient<ServiceWithEnumerableDependency<IFoo>>();
            var serviceProvider = CreateServiceProvider(serviceCollection);
            var service = serviceProvider.GetService<ServiceWithEnumerableDependency<IFoo>>();
            Assert.Empty(service.Dependencies);
        }

#endif
    }
}