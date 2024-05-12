using BasisCore.Runtime.UI.Window;
using UnityEngine;

namespace App.Configs
{
    [CreateAssetMenu(fileName = "WindowsConfig", menuName = "JellyMergeDefence/WindowsConfig")]
    public sealed class WindowsConfig : ScriptableObject
    {
        [field: SerializeField] public WindowView SplashWindowView { get; private set; }
        [field: SerializeField] public WindowView MetaWindowView { get; private set; }
    }
}