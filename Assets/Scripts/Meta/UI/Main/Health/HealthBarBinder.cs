using BasisCore.Runtime.UI;

namespace Meta.UI.Main.Health
{
    public sealed class HealthBarBinder : Binder<HealthModel, HealthBarView>
    {
        public HealthBarBinder(HealthModel model, HealthBarView view) : base(model, view)
        {
        }

        public override void Init()
        {
            Bind(_model.CurrentHealth, DisplayHealth);
        }

        private void DisplayHealth(int currentHealth)
        {
            _view.HealthText.SetText(currentHealth.ToString());
        }
    }
}