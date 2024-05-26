using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikeController : MonoBehaviour
{
    public characterController characterController;
    public LayerMask player;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("ok");
        if (collision.gameObject.layer == player)
        {
            characterController.spike();
        }
    }
}
