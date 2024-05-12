using BasisCore.Runtime.UI.Window;
using Meta.UI.Main.Health;
using UnityEngine;

namespace Meta.UI.Main
{
    public sealed class MetaMainWindowView : WindowView
    {
        [SerializeField] private HealthBarView _healthBarView;
        [SerializeField] private HealthBarView _healthPercentageBarView;

        public HealthBarView HealthBarView => _healthBarView;
        public HealthBarView HealthPercentageBarView => _healthPercentageBarView;
    }
}