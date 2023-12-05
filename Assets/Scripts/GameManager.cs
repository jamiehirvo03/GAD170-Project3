using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int coinsCollected = 0;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"Player has {coinsCollected} coins");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Player Death (triggered by touching spikes)
    public void playerDeath()
    {
        //Play death sound
        //Display particle system (blood)
        //Debug death confirmation
        //Reset the scene to respawn player
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Debug.Log("The player has died");
    }


    //Background music system
    private void playMusic()
    {
        //Randomly play music from a selection, if a track has already been played it will not be chosen again
        //Debug when track ends, changes and what track is playing
    }

    //Coin Collection when player touches it
    private void coinCollected()
    {
        //Add the coin to players coin count
        coinsCollected++;
        //Update coin count on UI
        //Remove the coin object from scene so it cannot be collected again
        //Play subtle particle effect
        //Play sound effect
        //Debug coin count
        Debug.Log($"Player collected a new coin! Their current count is: {coinsCollected}");
    }
    private void errorMessage()
    {
        //Error Debugging
        //Checking for null whenever referencing another script
    }

}
