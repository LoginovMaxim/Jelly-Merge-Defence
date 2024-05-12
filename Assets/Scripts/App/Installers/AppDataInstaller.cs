using App.Storage;
using BasisCore.Runtime.Storage;
using Zenject;

namespace App.Installers
{
    public sealed class AppDataInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesTo<Storage<AppSettingsStorageItem>>().AsSingle().NonLazy();
            
            Container.BindInterfacesTo<Storage<PersonalInfoStorageItem>>().AsSingle().NonLazy();
            Container.BindInterfacesTo<Storage<ProgressStorageItem>>().AsSingle().NonLazy();
            Container.BindInterfacesTo<Storage<CurrencyStorageItem>>().AsSingle().NonLazy();
            
            Container.BindInterfacesTo<ProfileProvider>().AsSingle().NonLazy();
        }
    }
}