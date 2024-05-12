using System.Threading;
using App.Services;
using App.Signals;
using BasisCore.Runtime.Commands;
using Zenject;

namespace App.Commands
{
    public sealed class RestartMatchCommand : Command<RestartMatchSignal>
    {
        private readonly IMatchSceneLoader _matchSceneLoader;

        private readonly CancellationTokenSource _tokenSource = new CancellationTokenSource();
        
        public RestartMatchCommand(IMatchSceneLoader matchSceneLoader, SignalBus signalBus) : base(signalBus)
        {
            _matchSceneLoader = matchSceneLoader;
        }

        protected override async void Execute()
        {
            await _matchSceneLoader.UnloadAsync(_tokenSource.Token);
            await _matchSceneLoader.LoadAsync(_tokenSource.Token);
        }

        public override void Dispose()
        {
            base.Dispose();
            _tokenSource.Cancel();
        }
    }
}