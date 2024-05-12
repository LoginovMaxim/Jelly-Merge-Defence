using App.Services;
using BasisCore.Runtime.Localizations;
using BasisCore.Runtime.SceneLoaders;
using BasisCore.Runtime.VisualEffects;
using Zenject;

namespace App.Installers
{
    public sealed class AppServicesInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesTo<Localization>().AsSingle().NonLazy();
            Container.BindInterfacesTo<AddressableSceneLoader>().AsSingle().NonLazy();
            Container.BindInterfacesTo<MetaSceneLoader>().AsSingle().NonLazy();
            Container.BindInterfacesTo<MatchSceneLoader>().AsSingle().NonLazy();
            Container.BindInterfacesTo<EffectEmitter>().AsSingle().NonLazy();
        }
    }
}