﻿using System;
using System.Collections.Generic;
using System.Reflection;
using Photosphere.DependencyInjection.Generators.MethodBodyGenerating.Strategies;
using Photosphere.DependencyInjection.Lifetimes;

namespace Photosphere.DependencyInjection.Generators.ObjectGraphs.DataTransferObjects
{
    internal interface IObjectGraph
    {
        Type ReturnType { get; }

        Type ImplementationType { get; }

        ConstructorInfo Constructor { get; }

        Lifetime Lifetime { get; }

        IReadOnlyList<IObjectGraph> Children { get; }

        bool IsEnumerable { get; }

        IGeneratingStrategy GeneratingStrategy { get; }
    }
}