using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagCollider : MonoBehaviour
{
    public GameManager manager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player has touched the flag!");

            if (manager != null)
            {
                manager.GetComponent<GameManager>().GameWin();
            }
        }
    }
}
