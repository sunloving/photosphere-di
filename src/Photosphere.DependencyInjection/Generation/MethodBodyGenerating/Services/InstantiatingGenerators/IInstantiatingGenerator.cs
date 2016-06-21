﻿using Photosphere.DependencyInjection.Generation.MethodBodyGenerating.ValueObjects;

namespace Photosphere.DependencyInjection.Generation.MethodBodyGenerating.Services.InstantiatingGenerators
{
    internal interface IInstantiatingGenerator
    {
        void Generate(GeneratingDesign design);
    }
}