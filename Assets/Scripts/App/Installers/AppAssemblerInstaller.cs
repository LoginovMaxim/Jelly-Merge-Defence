using System.Collections.Generic;
using App.Assemblers;
using App.Assemblers.Launchers;
using App.UI;
using BasisCore.Runtime.Assemblers.Launchers;
using BasisCore.Runtime.Extensions;
using BasisCore.Runtime.UI.LoadingSplash;
using BasisCore.Runtime.UI.Window;
using Zenject;

namespace App.Installers
{
    public sealed class AppAssemblerInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            var assemblerLaunchers = new List<IAssemblerLauncher>()
            {
                Container.BindWindowAssemblerLauncher<LoadingSplashWindow>(WindowNames.App.LoadingSplash, WindowLayer.LoadingSplash),
                Container.BindAssemblerLauncher<LocalizationLauncher>(),
                Container.BindAssemblerLauncher<MetaSceneLauncher>(),
            };
            
            Container.BindAssembler<AppAssembler>(assemblerLaunchers);
        }
    }
}