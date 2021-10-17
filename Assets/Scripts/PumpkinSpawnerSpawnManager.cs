using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpkinSpawnerSpawnManager : MonoBehaviour
{
    [SerializeField]
    private float range = 2;
    [SerializeField]
    private float cooldownTime = 5;
    [SerializeField]
    private float sinceCooldownTime = 0;
    [SerializeField]
    private float force = 1f;
    [SerializeField]
    private GameObject projectile;
    [SerializeField]
    private Transform firingPoint;
    [SerializeField]
    private Transform target;
    private void Update()
    {
        if (CooldownEnded())
        {
            if (TargetInRange(target))
            {
                FireAtTarget(target);
                sinceCooldownTime = 0;
            }
        } else
        {
            sinceCooldownTime += Time.deltaTime;
        }
    }    
    bool CooldownEnded()
    {
        return sinceCooldownTime >= cooldownTime;
    }
    bool TargetInRange(Transform target)
    {
        if (target != null)
        {
            Vector2 target2DPosition = new Vector2(target.position.x, target.position.y);
            Vector2 this2DPosition = new Vector2(transform.position.x, transform.position.y);
            return Vector2.Distance(target2DPosition, this2DPosition) <= range;
        }
        return false;
    }
    void FireAtTarget(Transform target)
    {
        Debug.Log("Firing");
        firingPoint.right = target.position - firingPoint.position;
        var instantiated = Instantiate(projectile, firingPoint.position, Quaternion.identity);
        instantiated.GetComponent<Rigidbody2D>().AddForce(new Vector2(firingPoint.right.x, firingPoint.right.y).normalized * force, ForceMode2D.Impulse);
    }
}
