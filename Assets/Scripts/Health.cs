using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int _maxHealth = 100;
    [SerializeField] private int _healValue = 35;
    [SerializeField] private int _damageValue = 25;

    private int _currentHealth;

    public int CurrentHealth => _currentHealth;
    public int MaxHealth => _maxHealth;

    private void Awake()
    {
        _currentHealth = _maxHealth;
    }

    public void TakeDamage()
    {
        _currentHealth -= _damageValue;

        if (_currentHealth < 0)
        {
            _currentHealth = 0;
        }
    }

    public void Heal()
    {
        _currentHealth += _healValue;

        if (_currentHealth > _maxHealth)
        {
            _currentHealth = _maxHealth;
        }
    }
}