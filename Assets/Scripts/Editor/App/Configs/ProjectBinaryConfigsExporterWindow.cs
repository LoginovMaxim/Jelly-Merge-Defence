using App.Configs;
using BasisCore.Editor.Configs;
using UnityEditor;
using UnityEngine;

namespace Editor.App.Configs
{
    public class ProjectBinaryConfigsExporterWindow : BaseBinaryConfigsExporterWindow<BinaryConfigId>
    {
        private const string SpreadsheetId = "1IYnRVHuRNjQYA9YMZLUoOh-eMiu1gMURq4lCzRi9QkI";
        
        protected override ConfigInfo[] _configInfos { get; } = new ConfigInfo[]
        {
            MakeConfigInfo(
                BinaryConfigId.Localization, 
                new LocalizationConfigImporter(), 
                SpreadsheetId, 
                "export localization config", 
                0.75F),
        };
        
        [MenuItem("Basis/Project Binary Configs Exporter")]
        private static void Init()
        {
            Debug.Log("Run Project Binary Configs Exporter");
            var window = GetWindow<ProjectBinaryConfigsExporterWindow>();
            window.titleContent = new GUIContent("Binary Configs Exporter");
            window.Show();
        }
    }
}