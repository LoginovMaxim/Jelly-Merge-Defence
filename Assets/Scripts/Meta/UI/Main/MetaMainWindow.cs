using BasisCore.Runtime.UI.Window;

namespace Meta.UI.Main
{
    public sealed class MetaMainWindow : Window<MetaMainWindowModel, MetaMainWindowView, MetaMainWindowController>
    {
        public MetaMainWindow(MetaMainWindowModel windowModel) : base(windowModel)
        {
        }

        protected override void InitWindowController()
        {
        }

        protected override void DeinitWindowController()
        {
        }
    }
}