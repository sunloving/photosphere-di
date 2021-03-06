﻿using System;
using System.Collections.Generic;

namespace Photosphere.DependencyInjection.Initialization.Registrations.ValueObjects
{
    internal interface IRegistry : IEnumerable<IRegistration>
    {
        void Add(IEnumerable<IRegistration> registrations);

        bool Contains(Type serviceType);

        IRegistration this[Type serviceType] { get; }

        int Count { get; }
    }
}