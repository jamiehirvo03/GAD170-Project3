using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EventBus : MonoBehaviour
{
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
    }

    // Start is called before the first frame update
    void Start()
    {
        coinsCollected = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
