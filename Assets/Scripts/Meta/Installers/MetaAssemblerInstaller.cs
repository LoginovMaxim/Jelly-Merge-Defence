using System.Collections.Generic;
using App.UI;
using BasisCore.Runtime.Assemblers.Launchers;
using BasisCore.Runtime.Extensions;
using BasisCore.Runtime.UI.Window;
using Meta.Assemblers;
using Meta.UI.Main;
using Zenject;

namespace Meta.Installers
{
    public sealed class MetaAssemblerInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            var assemblerLaunchers = new List<IAssemblerLauncher>()
            {
                Container.BindWindowAssemblerLauncher<MetaMainWindow>(WindowNames.Meta.Main, WindowLayer.Main),
            };
            
            Container.BindAssembler<MetaAssembler>(assemblerLaunchers);
        }
    }
}