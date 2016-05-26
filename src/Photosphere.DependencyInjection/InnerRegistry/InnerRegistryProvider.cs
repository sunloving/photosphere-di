﻿using System.Collections.Generic;
using Photosphere.DependencyInjection.Lifetimes;
using Photosphere.DependencyInjection.Registrations.Services;
using Photosphere.DependencyInjection.Registrations.Services.CompositionRoots;
using Photosphere.DependencyInjection.Registrations.ValueObjects;
using Photosphere.DependencyInjection.Resolving;

namespace Photosphere.DependencyInjection.InnerRegistry
{
    internal static class InnerRegistryProvider
    {
        private static readonly IRegistrationFactory RegistrationFactory;

        static InnerRegistryProvider()
        {
            InnerRegistry = new Registry();
            RegistrationFactory = new InnerRegistrationFactory();

            var registrations = new List<IRegistration>
            {
                GetInnerRegistration<RegistrationFactory>(),
                GetInnerRegistration<RegistryInitializer>(),
                GetInnerRegistration<Validator>(),
                GetInnerRegistration<AssembliesProvider>(),
                GetInnerRegistration<CompositionRootProvider>(),
                GetInnerRegistration<Registrator>(),
                GetInnerRegistration<Resolver>(),
                GetInnerRegistration<Registry>(),
            };
            Register(registrations);
        }

        public static IRegistry InnerRegistry { get; }

        private static IRegistration GetInnerRegistration<TService>()
        {
            return RegistrationFactory.Get<TService>(Lifetime.PerContainer);
        }

        private static void Register(IEnumerable<IRegistration> registrations)
        {
            foreach (var registration in registrations)
            {
                InnerRegistry.Add(registration);
            }
        }
    }
}