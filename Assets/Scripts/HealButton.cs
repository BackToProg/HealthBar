using UnityEngine;

public class HealButton : MonoBehaviour
{

    public void OnButtonClick()
    {
        HealthSystem.Instance.Heal(HealthSystem.Instance.HealValue);
    }
}