using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TreeEditor;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject coinPrefab;

    public bool gameWon = false;

    public Material coinCollector;
    public GameObject player;

    //list of chosen coin locations to spawn in instances
    public List<int> xpos = new List<int>(15) {0, 0, -7, 0, -40, -39, -37, -38, -38, -23, 23, 42, 45, 45, 42};
    public List<int> ypos = new List<int>(15) {2, 4, 5, 4, 11, 13, 13, 13, 13, 21, 21, 11, 11, 11, 11};
    public List<int> zpos = new List<int>(15) {10, 22, 42, 53, 53, 66, 78, 83, 92, 110, 110, 106, 91, 73, 52};

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (EventBus.Current.coinsCollected == 15)
        {
            player.GetComponent<Renderer>().material = coinCollector;
        }
    }

    //public void PauseGame()
    //{

    //}

    public void GameWin()
    {
        //Pause game
        Time.timeScale = 0;
        //Show 'win' screen
        gameWon = true;
    }

    //Player Death (triggered by touching spikes)
    public void PlayerDeath()
    {
        //Play death sound
        //Display particle system (blood)
        //Debug death confirmation
        Debug.Log("The player has died");
        //Reset the scene to respawn player
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


    //Background music system
    //private void PlayMusic()
    //{
        //Randomly play music from a selection, if a track has already been played it will not be chosen again
        //Debug when track ends, changes and what track is playing
    //}

    //Coin Collection when player touches it
   
}
