using System.Threading;
using App.Storage;
using BasisCore.Runtime.SceneLoaders;
using Cysharp.Threading.Tasks;
using UnityEngine.SceneManagement;

namespace App.Services
{
    public sealed class MetaSceneLoader : IMetaSceneLoader
    {
        private readonly ISceneLoader _sceneLoader;

        public MetaSceneLoader(ISceneLoader sceneLoader)
        {
            _sceneLoader = sceneLoader;
        }

        public async UniTask LoadAsync(CancellationToken token)
        {
            await _sceneLoader.LoadSceneAsync(
                Constants.MetaBundleKeys.MetaSceneKey, 
                LoadSceneMode.Single, 
                true,
                token);
        }

        public async UniTask UnloadAsync(CancellationToken token)
        {
            await _sceneLoader.UnloadSceneAsync(Constants.MetaBundleKeys.MetaSceneKey, token);
        }
    }
}