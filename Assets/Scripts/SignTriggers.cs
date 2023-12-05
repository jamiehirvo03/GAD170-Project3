using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SignTriggers : MonoBehaviour
{
    public TextDisplay textDisplay;

    private bool inTrigger = false;

    private int currentSign;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((inTrigger) && (Input.GetKeyDown(KeyCode.E)))
        {
            Debug.Log("Player has read the Sign");

            switch (currentSign)
            {
                case 1:
                    textDisplay.GetComponent<TextDisplay>().firstPopup();
                    break;
                case 2:
                    textDisplay.GetComponent<TextDisplay>().secondPopup();
                    break; 
                case 3:
                    textDisplay.GetComponent<TextDisplay>().thirdPopup();
                    break; 
                case 4:
                    textDisplay.GetComponent<TextDisplay>().fourthPopup();
                    break;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!inTrigger)
        {
            textDisplay.GetComponent<TextDisplay>().signPrompt();

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

            if ((other.gameObject.transform.position.z > 60) && other.gameObject.transform.position.z < 112)
            {
                Debug.Log("Player has entered the Fourth Sign Trigger");
                currentSign = 4;
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

    public int getCurrentSign()
    {
        return currentSign;
    }
}