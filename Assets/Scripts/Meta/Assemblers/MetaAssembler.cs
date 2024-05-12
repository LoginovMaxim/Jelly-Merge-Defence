using System.Collections.Generic;
using BasisCore.Runtime.Assemblers;
using BasisCore.Runtime.Assemblers.Launchers;
using Zenject;

namespace Meta.Assemblers
{
    public sealed class MetaAssembler : Assembler
    {
        public MetaAssembler(
            List<IAssemblerLauncher> assemblerParts, 
            SignalBus signalBus) : 
            base(assemblerParts, signalBus)
        {
        }

        protected override void OnStartAssembly()
        {
        }

        protected override void OnFinishAssembly()
        {
        }
    }
}