using System.Threading;
using App.Services;
using BasisCore.Runtime.Assemblers.Launchers;
using Cysharp.Threading.Tasks;

namespace App.Assemblers.Launchers
{
    public sealed class LevelLauncher : IAssemblerLauncher
    {
        private readonly ILevelLoader _levelLoader;

        public LevelLauncher(ILevelLoader levelLoader)
        {
            _levelLoader = levelLoader;
        }

        public async UniTask LaunchAsync(CancellationToken token)
        {
            await UniTask.Delay(500, cancellationToken: token);
            await UniTask.Delay(500, cancellationToken: token);
        }
    }
}