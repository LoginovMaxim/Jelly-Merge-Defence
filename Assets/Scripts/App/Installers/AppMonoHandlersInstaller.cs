using BasisCore.Runtime.Monos;
using BasisCore.Runtime.UI.Window.Factory;
using Zenject;

namespace App.Installers
{
    public sealed class AppMonoHandlersInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesTo<MonoUpdater>().FromComponentInHierarchy().AsSingle().NonLazy();
            Container.BindInterfacesTo<GameObjectFinder>().FromComponentInHierarchy().AsSingle().NonLazy();
            Container.BindInterfacesTo<ViewFactory>().FromComponentInHierarchy().AsSingle().NonLazy();
            Container.BindInterfacesTo<WindowViewFactory>().FromComponentInHierarchy().AsSingle().NonLazy();
            Container.BindInterfacesTo<ApplicationStatusHandler>().FromComponentInHierarchy().AsSingle().NonLazy();
        }
    }
}