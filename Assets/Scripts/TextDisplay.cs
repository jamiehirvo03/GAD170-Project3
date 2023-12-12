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

    private List<string> firstSign = new List<string>(3) { "To jump up on that ledge you'll want to\nPress [SPACE]!", "Hey you! See that ledge over there? I wonder how you could get up there?", "Whats that thing over there? Eh, I dunno. I found out this cool thing earlier though. Try pressing [SPACE]"};
    private List<string> secondSign = new List<string>(3) { "Watch out for the spikes!\nThey're Very Sharp!", "There's some spikes down there, would suck to fall on them!", "Are those spikes?? I can't tell. Maybe you should jump on them and find out..."};
    private List<string> thirdSign = new List<string>(3) { "Left: Log jumps\nRight: Platforms\nThe choice is yours", "So you probably noticed that there's two paths right?\nI heard one is pretty dangerous, be careful!", "Woah, what a view!"};

    private List<string> usedTexts = new List<string>();

    private string selectedText;

    // Update is called once per frame
    void Update()
    {
        coinCounter.text = $"Coins: {EventBus.Current.coinsCollected}";

        if (manager.GetComponent<GameManager>().gameWon == true)
        {
            WinText();
        }
    }

    public void ClearText()
    {
        textPopup.text = " ";
    }

    public void WinText()
    {
        if (EventBus.Current.coinsCollected == 15)
        {
            textPopup.text = "Congratulations, You Win!\nGreat job on collecting all the coins!!!!"; 
        }
        else
        {
            textPopup.text = "You win!\nMake sure to try again and collect all the coins for a special secret!";
        }
    }
    public void SignPrompt()
    {
        textPopup.text = "Press [E] to read sign";
    }

    public void FirstPopup()
    {
        if (usedTexts.Count > 0)
        {
            for (int i = 0; i < usedTexts.Count; i++)
            {
                int RandomIndex = Random.Range(0, firstSign.Count);
                selectedText = firstSign[RandomIndex];

                if (usedTexts[i] != firstSign[RandomIndex])
                {
                    textPopup.text = firstSign[RandomIndex];
                    usedTexts.Add(firstSign[RandomIndex]);
                }
                else
                {
                    RandomIndex = Random.Range(0, firstSign.Count);
                }
            }
        }
        else
        {
            int RandomIndex = Random.Range(0, firstSign.Count);
            textPopup.text = firstSign[RandomIndex];
            usedTexts.Add(firstSign[RandomIndex]);
        }
    }

    public void SecondPopup()
    {
        if (usedTexts.Count > 0)
        {
            for (int i = 0; i < usedTexts.Count; i++)
            {
                int RandomIndex = Random.Range(0, secondSign.Count);
                selectedText = secondSign[RandomIndex];

                if (usedTexts[i] != secondSign[RandomIndex])
                {
                    textPopup.text = secondSign[RandomIndex];
                    usedTexts.Add(secondSign[RandomIndex]);
                }
                else
                {
                    RandomIndex = Random.Range(0, secondSign.Count);
                }
            }
        }
        else
        {
            int RandomIndex = Random.Range(0, secondSign.Count);
            textPopup.text = secondSign[RandomIndex];
            usedTexts.Add(secondSign[RandomIndex]);
        }

    }

    public void ThirdPopup()
    {
        if (usedTexts.Count > 0)
        {
            for (int i = 0; i < usedTexts.Count; i++)
            {
                int RandomIndex = Random.Range(0, thirdSign.Count);
                selectedText = thirdSign[RandomIndex];

                if (usedTexts[i] != thirdSign[RandomIndex])
                {
                    textPopup.text = thirdSign[RandomIndex];
                    usedTexts.Add(thirdSign[RandomIndex]);
                }
                else
                {
                    RandomIndex = Random.Range(0, thirdSign.Count);
                }
            }
        }
        else
        {
            int RandomIndex = Random.Range(0, thirdSign.Count);
            textPopup.text = thirdSign[RandomIndex];
            usedTexts.Add(thirdSign[RandomIndex]);
        }
    }
}
