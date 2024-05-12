using App.Signals;
using BasisCore.Runtime.Signals;
using Zenject;

namespace App.Installers
{
    public sealed class AppSignalsInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            SignalBusInstaller.Install(Container);
            
            Container.DeclareSignal<ProgressServiceAddSignal>();
            Container.DeclareSignal<SwitchScreenSignal>();

            Container.DeclareSignal<PlayMatchSignal>();
            Container.DeclareSignal<QuitMatchSignal>();
            Container.DeclareSignal<RestartMatchSignal>();
        }
    }
}