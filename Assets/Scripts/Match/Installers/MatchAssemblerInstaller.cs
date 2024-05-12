using System.Collections.Generic;
using BasisCore.Runtime.Assemblers.Launchers;
using BasisCore.Runtime.Extensions;
using Match.Assemblers;
using Zenject;

namespace Match.Installers
{
    public sealed class MatchAssemblerInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            var assemblerLaunchers = new List<IAssemblerLauncher>();
            
            Container.BindAssembler<MatchAssembler>(assemblerLaunchers);
        }
    }
}