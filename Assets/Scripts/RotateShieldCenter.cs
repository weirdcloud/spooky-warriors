using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateShieldCenter : MonoBehaviour
{
    [SerializeField]
    private float rotationLerp = 0.2f;
    private void FixedUpdate()
    {
        Vector3 direction = Input.mousePosition;
        direction.z = -Camera.main.transform.position.z;
        direction = Camera.main.ScreenToWorldPoint(direction) - transform.position;
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(Vector3.forward, direction), rotationLerp);
    }
}
