using System.Collections.Generic;
using BasisCore.Runtime.Assemblers;
using BasisCore.Runtime.Assemblers.Launchers;
using Zenject;

namespace Match.Assemblers
{
    public sealed class MatchAssembler : Assembler
    {
        public MatchAssembler(
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