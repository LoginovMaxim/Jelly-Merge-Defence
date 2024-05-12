using App.Services;
using BasisCore.Runtime.Localizations;
using BasisCore.Runtime.SceneLoaders;
using BasisCore.Runtime.VisualEffects;
using Zenject;

namespace App.Installers
{
    public sealed class GameServicesInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesTo<Localization>().AsSingle().NonLazy();
            Container.BindInterfacesTo<SceneLoader>().AsSingle().NonLazy();
            Container.BindInterfacesTo<LevelLoader>().AsSingle().NonLazy();
            Container.BindInterfacesTo<EffectEmitter>().AsSingle().NonLazy();
        }
    }
}