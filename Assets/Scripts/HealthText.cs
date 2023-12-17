using TMPro;
using UnityEngine;

public class HealthText : MonoBehaviour
{
   [SerializeField] private TextMeshProUGUI _text;
   [SerializeField] private Health health;

   private void Start()
   {
      UpdateHealthText();
   }

   private void Update()
   {
      UpdateHealthText();
   }

   private void UpdateHealthText()
   {
      _text.text = $"{health.CurrentHealth} / {health.MaxHealth}";
   }
}
