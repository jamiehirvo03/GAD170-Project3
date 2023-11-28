using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondSign : MonoBehaviour
{
    private bool inTrigger = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if ((inTrigger) && (Input.GetKeyDown(KeyCode.E)))
        {
            Debug.Log("Player has read the Second Sign");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!inTrigger)
        {
            Debug.Log("Player has entered the Second Sign Trigger");
            inTrigger = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (inTrigger)
        {
            Debug.Log("Player has exited the Second Sign Trigger");
            inTrigger = false;
        }
    }
}
