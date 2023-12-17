using UnityEngine;

public class DamageSystem : MonoBehaviour
{
    [SerializeField] private int _damageValue = 25;
    
    public int DamageValue => _damageValue;
}
