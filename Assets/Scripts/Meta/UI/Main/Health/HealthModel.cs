using BasisCore.Runtime.Reactive;
using BasisCore.Runtime.UI;

namespace Meta.UI.Main.Health
{
    public sealed class HealthModel : IModel
    {
        public readonly ReactiveData<int> MaxHealth = new();
        public readonly ReactiveData<int> CurrentHealth = new();
    }
}