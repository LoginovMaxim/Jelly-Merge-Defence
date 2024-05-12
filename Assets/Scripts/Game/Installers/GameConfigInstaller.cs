using App.Configs;
using BasisCore.Runtime.Configs.UI;
using Zenject;
using ResourceProvider = BasisCore.Runtime.ResourceProviders.ResourceProvider;

namespace App.Installers
{
    public sealed class GameConfigInstaller : MonoInstaller
    {
        public ScreenAnimationConfig ScreenAnimationConfig;
        
        public override void InstallBindings()
        {
            Container.BindInterfacesTo<ScreenAnimationConfig>().FromScriptableObject(ScreenAnimationConfig).AsSingle().NonLazy();
            Container.BindInterfacesTo<ResourceProvider>().AsSingle().NonLazy();
            Container.BindInterfacesTo<ProjectBaseBinaryConfigManager>().AsSingle().NonLazy();
        }
    }
}