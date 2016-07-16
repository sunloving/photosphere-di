using Photosphere.DependencyInjection.Initialization.Saturation.Generation.MethodBodyGenerating.Services.InstantiatingGenerators;
using Photosphere.DependencyInjection.Initialization.Saturation.Generation.MethodBodyGenerating.ValueObjects;

namespace Photosphere.DependencyInjection.Initialization.Saturation.Generation.MethodBodyGenerating.Services.GeneratingStrategies
{
    internal class IntantiationProvidingGeneratingStrategy : GeneratingStrategyBase, IIntantiationProvidingGeneratingStrategy
    {
        private readonly IObjectInstantiatingGenerator _objectInstantiatingGenerator;

        public IntantiationProvidingGeneratingStrategy(IObjectInstantiatingGenerator objectInstantiatingGenerator)
        {
            _objectInstantiatingGenerator = objectInstantiatingGenerator;
        }

        protected override void GenerateDependencyProviding(GeneratingDesign design)
        {
            _objectInstantiatingGenerator.Generate(design);
        }
    }
}