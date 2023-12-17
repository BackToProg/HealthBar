using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SmoothHealthBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private float _smoothSpeed = 10f;

    private int _currentHealth;
    private Coroutine _coroutine;
    private bool _isCoroutineStopped;

    private void Start()
    {
        HealthSystem.Instance.OnHealthChange += OnHealthChange;
    }

    private void Update()
    {
        if (_isCoroutineStopped && IsHealthInRange())
        {
            StopCoroutine(_coroutine);
        }
    }

    private void OnHealthChange(object sender, EventArgs e)
    {
        _currentHealth = HealthSystem.Instance.CurrentHealth;
        _coroutine = StartCoroutine(UpdateSmoothBarValue());
    }

    private IEnumerator UpdateSmoothBarValue()
    {
        _isCoroutineStopped = false;
        
        while (_slider.value != _currentHealth)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, _currentHealth,
                Time.deltaTime * _smoothSpeed);

            yield return null;
        }

        _isCoroutineStopped = true;
    }

    private bool IsHealthInRange() => _currentHealth > 0 && _currentHealth <  HealthSystem.Instance.MaxHealth;
}