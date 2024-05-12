using System.Threading;
using App.Services;
using App.Signals;
using BasisCore.Runtime.Commands;
using Zenject;

namespace App.Commands
{
    public sealed class PlayMatchCommand : Command<PlayMatchSignal>
    {
        private readonly IMetaSceneLoader _metaSceneLoader;
        private readonly IMatchSceneLoader _matchSceneLoader;

        private readonly CancellationTokenSource _tokenSource = new CancellationTokenSource();
        
        public PlayMatchCommand(
            IMetaSceneLoader metaSceneLoader, 
            IMatchSceneLoader matchSceneLoader, 
            SignalBus signalBus) : 
            base(signalBus)
        {
            _metaSceneLoader = metaSceneLoader;
            _matchSceneLoader = matchSceneLoader;
        }

        protected override async void Execute()
        {
            await _metaSceneLoader.UnloadAsync(_tokenSource.Token);
            await _matchSceneLoader.LoadAsync(_tokenSource.Token);
        }

        public override void Dispose()
        {
            base.Dispose();
            _tokenSource.Cancel();
        }
    }
}