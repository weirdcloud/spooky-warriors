using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    [SerializeField]
    private Image filling;
    public void HandleHealthChange(int maxHealth, int currentHealth)
    {
        filling.fillAmount = (float)currentHealth / (float)maxHealth;
    }
}
