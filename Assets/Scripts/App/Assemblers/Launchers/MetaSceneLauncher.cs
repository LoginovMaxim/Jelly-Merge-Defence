using System.Threading;
using App.Services;
using BasisCore.Runtime.Assemblers.Launchers;
using Cysharp.Threading.Tasks;

namespace App.Assemblers.Launchers
{
    public sealed class MetaSceneLauncher : IAssemblerLauncher
    {
        private readonly IMetaSceneLoader _metaSceneLoader;

        public MetaSceneLauncher(IMetaSceneLoader metaSceneLoader)
        {
            _metaSceneLoader = metaSceneLoader;
        }

        public async UniTask LaunchAsync(CancellationToken token)
        {
            await UniTask.Delay(500, cancellationToken: token);
            await _metaSceneLoader.LoadAsync(token);
            await UniTask.Delay(500, cancellationToken: token);
        }
    }
}