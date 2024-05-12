using System.Threading;
using App.Services;
using App.Signals;
using BasisCore.Runtime.Commands;
using Zenject;

namespace App.Commands
{
    public sealed class QuitMatchCommand : Command<QuitMatchSignal>
    {
        private readonly ILevelLoader _levelLoader;
        //private readonly IMatchSceneLoader _matchSceneLoader;

        private readonly CancellationTokenSource _tokenSource = new CancellationTokenSource();
        
        public QuitMatchCommand(
            ILevelLoader levelLoader, 
            //IMatchSceneLoader matchSceneLoader, 
            SignalBus signalBus) : 
            base(signalBus)
        {
            _levelLoader = levelLoader;
            //_matchSceneLoader = matchSceneLoader;
        }

        protected override async void Execute()
        {
            //await _matchSceneLoader.UnloadAsync(_tokenSource.Token);
            await _levelLoader.LoadAsync(_tokenSource.Token);
        }

        public override void Dispose()
        {
            base.Dispose();
            _tokenSource.Cancel();
        }
    }
}