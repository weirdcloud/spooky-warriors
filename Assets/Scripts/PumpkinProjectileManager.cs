using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PumpkinProjectileManager : MonoBehaviour
{
    [SerializeField]
    int damage = 1;
    [SerializeField]
    private bool wasDeflected = false;
    public UnityEvent<bool> onDeflectedChange;
    public void SetDeflected(bool value)
    {
        wasDeflected = value;
        onDeflectedChange.Invoke(wasDeflected);
    }
    private void Die()
    {
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.name);
        Debug.Log("Shield - " + CollisionWithShield(other).ToString() + " Player - " + CollisionWithPlayer(other).ToString() + " Spawner - " + CollisionWithSpawner(other).ToString());
        Debug.Log("deflected - " + wasDeflected.ToString());
        if (wasDeflected)
        {
            if (CollisionWithSpawner(other))
            {
                other.GetComponent<PumpkinSpawnerHealthManager>().ChangeHealth(gameObject, -damage);
                Die();
            }
            else if (!(CollisionWithShield(other) || CollisionWithPlayer(other)))
            {
                Die();
            }
        }
        else
        {
            if (CollisionWithPlayer(other))
            {
                other.GetComponent<PlayerHealthManager>().ChangeHealth(gameObject, -damage);
                Die();
            }
            else if (!(CollisionWithShield(other) || CollisionWithSpawner(other)))
            {
                Die();
            }
        }
    }
    // rewrite using something more reliable than names
    private bool CollisionWithShield(Collider2D other)
    {
        return other.name == "Shield";
    }
    private bool CollisionWithPlayer(Collider2D other)
    {
        return other.name == "Player";
    }
    private bool CollisionWithSpawner(Collider2D other)
    {
        return other.gameObject.GetComponent<PumpkinSpawnerHealthManager>() != null;
    }
}
