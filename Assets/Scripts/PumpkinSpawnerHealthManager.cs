using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PumpkinSpawnerHealthManager : MonoBehaviour
{
    [SerializeField]
    private int maxHealth = 3;
    [SerializeField]
    private int currentHealth;

    public UnityEvent<int, int> OnChangeHealth;

    private void Awake()
    {
        currentHealth = maxHealth;
    }

    public void ChangeHealth(GameObject dealer, int amount)
    {
        currentHealth += amount;
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        else if (currentHealth < 0)
        {
            currentHealth = 0;
        }
        OnChangeHealth.Invoke(maxHealth, currentHealth);
        if (currentHealth == 0)
        {
            Die(dealer);
        }
    }
    public void Die(GameObject killer)
    {
        Debug.Log(gameObject.name + " was killed by " + killer.name);
        Destroy(gameObject);
    }
}
