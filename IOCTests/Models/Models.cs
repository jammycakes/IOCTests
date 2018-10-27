using System;
using System.Collections.Generic;

namespace IOCTests
{
    public class Dependency
    {
    }

    public class FuncService
    {
        private readonly Func<Dependency> _dependencyFunc;

        public Dependency Dependency => _dependencyFunc();

        public FuncService(Func<Dependency> dependencyFunc)
        {
            _dependencyFunc = dependencyFunc;
        }
    }

    public class LazyService
    {
        private readonly Lazy<Dependency> _dependencyLazy;

        public Dependency Dependency => _dependencyLazy.Value;

        public LazyService(Lazy<Dependency> dependencyLazy)
        {
            _dependencyLazy = dependencyLazy;
        }
    }

    public class ServiceA
    {
        public Dependency Dependency { get; }

        public ServiceA(Dependency dependency)
        {
            Dependency = dependency;
        }
    }

    public class ServiceB
    {
        public Dependency Dependency { get; }

        public ServiceB(Dependency dependency)
        {
            Dependency = dependency;
        }
    }

    public class DualService
    {
        public ServiceA ServiceA { get; }
        public ServiceB ServiceB { get; }

        public DualService(ServiceA serviceA, ServiceB serviceB)
        {
            ServiceA = serviceA;
            ServiceB = serviceB;
        }
    }

    public class ServiceWithEnumerableDependency<T>
    {
        public IEnumerable<T> Dependencies { get; }

        public ServiceWithEnumerableDependency(IEnumerable<T> dependencies)
        {
            Dependencies = dependencies;
        }
    }

    public interface IFoo { }
}