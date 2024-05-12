using BasisCore.Runtime.UI.LoadingSplash;
using BasisCore.Runtime.UI.Screens;
using BasisCore.Runtime.UI.Screens.Animations.Hiding;
using BasisCore.Runtime.UI.Screens.Animations.Showing;
using Zenject;

namespace App.Installers
{
    public sealed class AppUIInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            BindSplash();
            BindScreenAnimators();
        }

        private void BindSplash()
        {
            Container.Bind<LoadingSplashWindowModel>().AsSingle().NonLazy();
            Container.Bind<LoadingSplashWindow>().AsSingle().NonLazy();
        }

        private void BindScreenAnimators()
        {
            Container.BindInterfacesTo<FadeOutShowingScreenAnimator>().AsSingle().NonLazy();
            Container.BindInterfacesTo<FromLeftShowingScreenAnimator>().AsSingle().NonLazy();
            Container.BindInterfacesTo<FromRightShowingScreenAnimator>().AsSingle().NonLazy();
            Container.BindInterfacesTo<FromUpShowingScreenAnimator>().AsSingle().NonLazy();
            Container.BindInterfacesTo<FromDownShowingScreenAnimator>().AsSingle().NonLazy();
            
            Container.BindInterfacesTo<FadeInHidingScreenAnimator>().AsSingle().NonLazy();
            Container.BindInterfacesTo<ToLeftHidingScreenAnimator>().AsSingle().NonLazy();
            Container.BindInterfacesTo<ToRightHidingScreenAnimator>().AsSingle().NonLazy();
            Container.BindInterfacesTo<ToUpHidingScreenAnimator>().AsSingle().NonLazy();
            Container.BindInterfacesTo<ToDownHidingScreenAnimator>().AsSingle().NonLazy();
            
            Container.BindInterfacesTo<ScreenAnimationService>().AsSingle().NonLazy();
        }
    }
}