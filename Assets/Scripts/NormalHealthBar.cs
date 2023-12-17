using UnityEngine;
using UnityEngine.UI;


public class NormalHealthBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private Health health;
        
    private void Awake()
    {
        _slider.value = health.MaxHealth;
    }

    private void Update()
    {
        UpdateBarValue(health.CurrentHealth);
    }

    private void UpdateBarValue(int value)
    {
        _slider.value = value;
    }
}