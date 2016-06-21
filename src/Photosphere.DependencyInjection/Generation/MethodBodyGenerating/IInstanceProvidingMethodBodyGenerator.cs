﻿using Photosphere.DependencyInjection.Generation.MethodBodyGenerating.ValueObjects;

namespace Photosphere.DependencyInjection.Generation.MethodBodyGenerating
{
    internal interface IInstanceProvidingMethodBodyGenerator
    {
        void Generate(GeneratingDesign design);
    }
}