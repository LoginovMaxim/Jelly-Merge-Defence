using System.Collections.Generic;
using BasisCore.Runtime.Assemblers;
using BasisCore.Runtime.Assemblers.Launchers;
using Zenject;

namespace App.Assemblers
{
    public sealed class AppAssembler : Assembler
    {
        public AppAssembler(
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