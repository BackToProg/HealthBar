using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SmoothHealthBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private float _smoothSpeed = 10f;
    [SerializeField] private Health _health;

    private void Awake()
    {
        _slider.value = _health.MaxHealth;
    }

    private void Update()
    {
        StartCoroutine(UpdateSmoothBarValue());
    }

    private IEnumerator UpdateSmoothBarValue()
    {
        while (_slider.value != _health.CurrentHealth)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, _health.CurrentHealth,
                Time.deltaTime * _smoothSpeed);

            yield return null;
        }
    }
    
}