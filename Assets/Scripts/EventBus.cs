using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EventBus : MonoBehaviour
{
    private GameManager manager;
    
    private static EventBus _current;
    public static EventBus Current { get { return _current; } }

    public int coinsCollected;

    private void Awake()
    {
        if (_current != null && _current != this)
        {
            Destroy(_current);
        } 
        else
        {
            _current = this;
        }

        manager = GetComponent<GameManager>();

        EventBus.Current.coinsCollected = 0;
        EventBus.Current.SpawnCoins();
    }

    public void SpawnCoins()
    {
        for (int i = 0; i < 15; i++)
        {
            Vector3 spawnposition = new Vector3(manager.xpos[i], manager.ypos[i], manager.zpos[i]);

            GameObject coin = Instantiate(manager.coinPrefab, spawnposition, Quaternion.identity) as GameObject;
        }
    }

    public void CoinCollected()
    {
        //Add the coin to players coin count
        coinsCollected++;
        //Update coin count on UI
        //Remove the coin object from scene so it cannot be collected again
        //Play subtle particle effect
        //Play sound effect
        //Debug coin count
        Debug.Log($"Player collected a new coin! Their current count is:");
    }
}
