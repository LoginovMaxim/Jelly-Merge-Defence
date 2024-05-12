using System.Threading;
using App.Storage;
using BasisCore.Runtime.SceneLoaders;
using Cysharp.Threading.Tasks;
using UnityEngine.SceneManagement;

namespace App.Services
{
    public sealed class LevelLoader : ILevelLoader
    {
        private readonly IProfileProvider _profileProvider;
        private readonly ISceneLoader _sceneLoader;

        public LevelLoader(IProfileProvider profileProvider, ISceneLoader sceneLoader)
        {
            _sceneLoader = sceneLoader;
            _profileProvider = profileProvider;
        }

        public async UniTask LoadAsync(CancellationToken token)
        {
            await _sceneLoader.LoadSceneAsync(
                string.Format(Constants.LevelBundleKeys.LevelSceneKeyFormat, _profileProvider.ProgressData.Level), 
                LoadSceneMode.Additive, 
                true,
                token);
        }

        public async UniTask UnloadAsync(CancellationToken token)
        {
            await _sceneLoader.UnloadSceneAsync(
                string.Format(Constants.LevelBundleKeys.LevelSceneKeyFormat, _profileProvider.ProgressData.Level), 
                token);
        }
    }
}