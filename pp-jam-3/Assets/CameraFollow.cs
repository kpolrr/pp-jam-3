using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothspeed = 0.125f;
    private float smoothedpos;
    void Update()
    {
        smoothedpos = Mathf.Lerp(transform.position.y, target.position.y, smoothspeed);
        transform.position = new Vector3(0, smoothedpos, transform.position.z);

    }
}
