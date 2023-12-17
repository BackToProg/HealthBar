using System;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    [SerializeField] private int _maxHealth = 100;
    [SerializeField] private int _healValue = 35;

    private int _currentHealth;

    public static HealthSystem Instance { get; private set; }
    public event EventHandler OnHealthChange;

    public int HealValue => _healValue;
    public int CurrentHealth => _currentHealth;
    public int MaxHealth => _maxHealth;

    private void Awake()
    {
        if (Instance != null)
        {
            Debug.LogError($"Существует более чем один экземпляр класса NewBaseFlagSpawner {transform} - {Instance}");
            Destroy(gameObject);
            return;
        }

        Instance = this;

        _currentHealth = _maxHealth;
    }

    public void TakeDamage(int damage)
    {
        _currentHealth -= damage;

        if (_currentHealth < 0)
        {
            _currentHealth = 0;
        }

        OnHealthChange?.Invoke(this, EventArgs.Empty);
    }

    public void Heal(int healValue)
    {
        _currentHealth += healValue;

        if (_currentHealth > _maxHealth)
        {
            _currentHealth = _maxHealth;
        }

        OnHealthChange?.Invoke(this, EventArgs.Empty);
    }
}