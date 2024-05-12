using BasisCore.Runtime.UI.Window;
using Meta.UI.Main.Health;

namespace Meta.UI.Main
{
    public sealed class MetaMainWindowModel : WindowModel
    {
        public readonly HealthModel Health = new();
    }
}