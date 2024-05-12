using App.Commands;
using BasisCore.Runtime.Commands;
using Zenject;

namespace App.Installers
{
    public sealed class AppCommandsInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesTo<ProgressServiceAddCommand>().AsSingle().NonLazy();
            Container.BindInterfacesTo<PlayMatchCommand>().AsSingle().NonLazy();
            Container.BindInterfacesTo<QuitMatchCommand>().AsSingle().NonLazy();
            Container.BindInterfacesTo<RestartMatchCommand>().AsSingle().NonLazy();
        }
    }
}