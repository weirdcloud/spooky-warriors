using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldDeflect : MonoBehaviour
{
    [SerializeField]
    float force = 3f;
    private void OnTriggerEnter2D(Collider2D other)
    {
        var pumpkinManager = other.GetComponent<PumpkinProjectileManager>();
        if (pumpkinManager != null)
        {
            pumpkinManager.SetDeflected(true);
            other.GetComponent<Rigidbody2D>().AddForce(new Vector2(transform.up.x, transform.up.y).normalized * force, ForceMode2D.Impulse);
        }
    }
}
