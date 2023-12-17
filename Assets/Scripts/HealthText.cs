using System;
using TMPro;
using UnityEngine;

public class HealthText : MonoBehaviour
{
   [SerializeField] private TextMeshProUGUI _text;

   private void Start()
   {
      UpdateHealthText();
      HealthSystem.Instance.OnHealthChange += OnHealthChange;
   }

   private void OnHealthChange(object sender, EventArgs e)
   {
      UpdateHealthText();
   }

   private void UpdateHealthText()
   {
      _text.text = $"{HealthSystem.Instance.CurrentHealth} / {HealthSystem.Instance.MaxHealth}";
   }
}
