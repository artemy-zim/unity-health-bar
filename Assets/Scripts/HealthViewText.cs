using TMPro;
using UnityEngine;

public class HealthViewText : HealthView
{
    [SerializeField] private TextMeshProUGUI _text;

    protected override void UpdateView()
    {
        string text = $"Health: {Health.CurrentHealth}/{MaxHealth}";

        _text.text = text;
    }
}
