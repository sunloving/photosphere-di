using System.Reflection.Emit;

namespace Photosphere.DependencyInjection.Generators.MethodBodyGenerating.Services.Strategies
{
    internal abstract class GeneratingStrategyBase : IGeneratingStrategy
    {
        public LocalBuilder Generate(GeneratingDesign design)
        {
            return design.Designer
                .DeclareVariable(design.ObjectGraph.ReturnType)
                .AssignTo(v => GenerateDependencyProviding(design))
                .Variable;
        }

        protected abstract void GenerateDependencyProviding(GeneratingDesign design);
    }
}