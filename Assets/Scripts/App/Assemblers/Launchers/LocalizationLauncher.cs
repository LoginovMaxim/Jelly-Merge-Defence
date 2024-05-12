using System.Threading;
using App.Configs;
using BasisCore.Runtime.Assemblers.Launchers;
using BasisCore.Runtime.Configs.Localization;
using BasisCore.Runtime.Localizations;
using Cysharp.Threading.Tasks;

namespace App.Assemblers.Launchers
{
    public sealed class LocalizationLauncher : IAssemblerLauncher
    {
        private readonly IProjectBaseBinaryConfigManager _baseBinaryConfigManager;
        private readonly ILocalization _localization;

        private Language _language = Language.English;
        
        public LocalizationLauncher(IProjectBaseBinaryConfigManager baseBinaryConfigManager, ILocalization localization)
        {
            _baseBinaryConfigManager = baseBinaryConfigManager;
            _localization = localization;
        }

        public async UniTask LaunchAsync(CancellationToken token)
        {
            await _baseBinaryConfigManager.LoadLocalAsync(true, new CancellationToken());
            
            var localizationConfig = _baseBinaryConfigManager.GetConfig(BinaryConfigId.Localization);
            var entity = localizationConfig.GetEntity<LocalizationConfigEntity>(LocalizationConfigEntity.InstanceId);

            _localization.InitializeLocalizationTable(entity.ToTables());
            await UniTask.Delay(500, cancellationToken: token);
        }
    }
}