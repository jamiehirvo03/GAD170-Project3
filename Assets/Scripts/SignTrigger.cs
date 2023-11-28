using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignTrigger : MonoBehaviour
{
    private bool inTrigger = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((inTrigger) && (Input.GetKeyDown(KeyCode.E)))
        {
            Debug.Log("Player has read the sign");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!inTrigger)
        {
            Debug.Log("Player has entered the sign trigger");
            inTrigger = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (inTrigger)
        {
            Debug.Log("Player has exited the sign trigger");
            inTrigger = false;
        }
    }
}
