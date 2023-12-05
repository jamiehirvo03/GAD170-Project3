using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextDisplay : MonoBehaviour
{
    public GameManager manager;

    public TextMeshProUGUI coinCounter;
    public TextMeshProUGUI textPopup;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coinCounter.text = $"Coins: {manager.GetComponent<GameManager>().coinsCollected}";
    }

    public void ClearText()
    {
        textPopup.text = " ";
    }

    public void signPrompt()
    {
        textPopup.text = "Press [E] to read sign";
    }

    public void firstPopup()
    {
        textPopup.text = "To jump up on that ledge you'll want to\nPress [SPACE] !";
    }

    public void secondPopup()
    {
        textPopup.text = "Watch out for the spikes!\nThey're Very Sharp!";
    }

    public void thirdPopup()
    {
        textPopup.text = "Left: Easy log jumps\nRight: Difficult moving platorms\nThe choice is yours";
    }

    public void fourthPopup()
    {
        textPopup.text = "You see that platform up there??\nI heard that maybe if you collect all coins you can\nunlock something pretty cool!";
    }
}
