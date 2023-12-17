using UnityEngine;

[RequireComponent(typeof(DamageSystem))]
public class HitButton : MonoBehaviour
{
    private DamageSystem _damageSystem;
    
    private void Awake()
    {
        _damageSystem = GetComponent<DamageSystem>();
    }

    public void OnButtonClick()
    {
        HealthSystem.Instance.TakeDamage(_damageSystem.DamageValue);
    }
}
