using UnityEngine;
using UnityEngine.UI;

public class HealthViewBar : HealthView
{
    [SerializeField] private Slider _slider;

    protected override void UpdateView()
    {
        _slider.normalizedValue = Health.CurrentHealth / MaxHealth;
    }
}
