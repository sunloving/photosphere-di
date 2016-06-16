﻿using Photosphere.DependencyInjection.IntegrationTests.TestObjects.Objects;
using Xunit;

namespace Photosphere.DependencyInjection.IntegrationTests.Tests.GetInstaces
{
    public class GetInstanceRegisteringByCommonInterfaceTests
    {
        [Fact]
        internal void GetInstance_ByFirstLevelInterface_NotNull()
        {
            var container = new DependencyContainer();

            var result = container.GetInstance<IService11>();

            Assert.NotNull(result);
        }

        [Fact]
        internal void GetInstance_ByFirstLevelInterface_ExpectedType()
        {
            var container = new DependencyContainer();

            var result = container.GetInstance<IService11>();

            Assert.IsType<Service11>(result); ;
        }

        [Fact]
        internal void GetInstance_BySecondLevelInterface_NotNull()
        {
            var container = new DependencyContainer();

            var result = container.GetInstance<IService1>();

            Assert.NotNull(result);
        }

        [Fact]
        internal void GetInstance_BySecondLevelInterface_ExpectedType()
        {
            var container = new DependencyContainer();

            var result = container.GetInstance<IService1>();

            Assert.True(result is Service11 || result is Service12);
        }

        [Fact]
        internal void GetInstance_ByThirdLevelInterface_NotNull()
        {
            var container = new DependencyContainer();

            var result = container.GetInstance<IService>();

            Assert.NotNull(result);
        }

        [Fact]
        internal void GetInstance_ByThirdLevelInterface_ExpectedType()
        {
            var container = new DependencyContainer();

            var result = container.GetInstance<IService>();

            Assert.True(result is Service11 || result is Service12 || result is Service21 || result is Service22);
        }

        [Fact]
        internal void GetInstance_ByClass_NotNull()
        {
            var container = new DependencyContainer();

            var result = container.GetInstance<Service11>();

            Assert.NotNull(result);
        }

        [Fact]
        internal void GetInstance_WithClassDependency_ExpectedType()
        {
            var container = new DependencyContainer();

            var result = container.GetInstance<Service22>();

            Assert.IsType<Service21>(result.Service21);
        }
    }
}