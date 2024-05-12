using System.Collections.Generic;
using App.Assemblers;
using App.Assemblers.Launchers;
using App.Configs;
using BasisCore.Runtime.Assemblers.Launchers;
using BasisCore.Runtime.Extensions;
using BasisCore.Runtime.UI.LoadingSplash;
using BasisCore.Runtime.UI.Window;
using Zenject;

namespace App.Installers
{
    public sealed class GameAssemblerInstaller : MonoInstaller
    {
        public WindowsConfig WindowsConfig;
        
        public override void InstallBindings()
        {
            var assemblerLaunchers = new List<IAssemblerLauncher>()
            {
                Container.BindWindowAssemblerLauncherWithPrefab<LoadingSplashWindow>(WindowsConfig.SplashWindowView, WindowLayer.LoadingSplash),
                Container.BindAssemblerLauncher<LevelLauncher>(),
            };
            
            Container.BindAssembler<GameAssembler>(assemblerLaunchers);
        }
    }
}