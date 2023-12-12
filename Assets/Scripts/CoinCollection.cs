using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollection : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player has touched a coin");

            if (EventBus.Current != null)
            {
                EventBus.Current.CoinCollected();

                Destroy(this.gameObject);
            }
        }
    }
}
