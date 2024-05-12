using BasisCore.Runtime.UI;
using TMPro;
using UnityEngine;

namespace Meta.UI.Main.Health
{
    public sealed class HealthBarView : MonoBehaviour, IView
    {
        [SerializeField] private TextMeshProUGUI _healthText;

        public TextMeshProUGUI HealthText => _healthText;
    }
}