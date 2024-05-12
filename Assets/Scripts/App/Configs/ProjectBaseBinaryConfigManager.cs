using BasisCore.Runtime.Configs.BinaryConfigs;
using BasisCore.Runtime.ResourceProviders;

namespace App.Configs
{
    public sealed class ProjectBaseBinaryConfigManager : BaseBinaryConfigManager<BinaryConfigId>, IProjectBaseBinaryConfigManager
    {
        public ProjectBaseBinaryConfigManager(IResourceProvider resourceProvider) : base(resourceProvider)
        {
        }
    }
}