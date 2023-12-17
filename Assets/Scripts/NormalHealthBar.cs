using System;
using UnityEngine;
using UnityEngine.UI;

public class NormalHealthBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    private void Start()
    {
        HealthSystem.Instance.OnHealthChange += OnHealthChange;
    }

    private void OnHealthChange(object sender, EventArgs e)
    {
        UpdateBarValue(HealthSystem.Instance.CurrentHealth);
    }

    private void UpdateBarValue(int value)
    {
        _slider.value = value;
    }
}