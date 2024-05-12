using App.Configs;
using BasisCore.Runtime.Configs.UI;
using BasisCore.Runtime.ResourceProviders;
using Zenject;

namespace App.Installers
{
    public sealed class AppConfigInstaller : MonoInstaller
    {
        public ScreenAnimationConfig ScreenAnimationConfig;
        
        public override void InstallBindings()
        {
            Container.BindInterfacesTo<ScreenAnimationConfig>().FromScriptableObject(ScreenAnimationConfig).AsSingle().NonLazy();
            Container.BindInterfacesTo<AddressableResourceProvider>().AsSingle().NonLazy();
            Container.BindInterfacesTo<ProjectBaseBinaryConfigManager>().AsSingle().NonLazy();
        }
    }
}