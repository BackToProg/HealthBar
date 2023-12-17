using UnityEngine;
using UnityEngine.UI;


public class NormalHealthBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private Health _health;
        
    private void Awake()
    {
        _slider.value = _health.MaxHealth;
    }

    private void Update()
    {
        UpdateBarValue(_health.CurrentHealth);
    }

    private void UpdateBarValue(int value)
    {
        _slider.value = value;
    }
}