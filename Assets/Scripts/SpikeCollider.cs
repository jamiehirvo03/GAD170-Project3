using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeCollider : MonoBehaviour
{
    public GameManager manager;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player has touched spikes");

            if (manager != null)
            {
                manager.GetComponent<GameManager>().PlayerDeath();
            }
            
        }
    }
}
