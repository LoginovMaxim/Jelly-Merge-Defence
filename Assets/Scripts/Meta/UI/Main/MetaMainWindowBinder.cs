using BasisCore.Runtime.UI.Window;
using Meta.UI.Main.Health;

namespace Meta.UI.Main
{
    public class MetaMainWindowBinder : WindowBinder<MetaMainWindowModel, MetaMainWindowView>
    {
        private readonly HealthBarBinder _healthBarBinder;
        
        public MetaMainWindowBinder(MetaMainWindowModel model, MetaMainWindowView view) : base(model, view)
        {
            _healthBarBinder = new HealthBarBinder(_model.Health, _view.HealthBarView);
        }

        public override void Init()
        {
            _healthBarBinder.Init();
        }

        public override void Deinit()
        {
            _healthBarBinder.Deinit();
            base.Deinit();
        }
    }
}