using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SignTriggers : MonoBehaviour
{
    public TextDisplay textDisplay;

    private bool inTrigger = false;

    private int currentSign;

    // Update is called once per frame
    void Update()
    {
        if ((inTrigger) && (Input.GetKeyDown(KeyCode.E)))
        {
            Debug.Log("Player has read the Sign");

            switch (currentSign)
            {
                case 1:
                    textDisplay.GetComponent<TextDisplay>().FirstPopup();
                    break;
                case 2:
                    textDisplay.GetComponent<TextDisplay>().SecondPopup();
                    break; 
                case 3:
                    textDisplay.GetComponent<TextDisplay>().ThirdPopup();
                    break; 
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!inTrigger)
        {
            textDisplay.GetComponent<TextDisplay>().SignPrompt();

            if ((other.gameObject.transform.position.z > -15) && other.gameObject.transform.position.z < 15)
            {
                Debug.Log("Player has entered the First Sign Trigger");
                currentSign = 1;
            }

            if ((other.gameObject.transform.position.z > 15) && other.gameObject.transform.position.z < 30)
            {
                Debug.Log("Player has entered the Second Sign Trigger");
                currentSign = 2;
            }

            if ((other.gameObject.transform.position.z > 30) && other.gameObject.transform.position.z < 60)
            {
                Debug.Log("Player has entered the Third Sign Trigger");
                currentSign = 3;
            }

            inTrigger = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (inTrigger)
        {
            Debug.Log("Player has exited a Sign Trigger");
            textDisplay.GetComponent<TextDisplay>().ClearText();
            inTrigger = false;
        }
    }

    public int GetCurrentSign()
    {
        return currentSign;
    }
}
