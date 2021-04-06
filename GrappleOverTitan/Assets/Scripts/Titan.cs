using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Titan : MonoBehaviour
{
    public GameObject mainGame;
    private bool passed = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var playerObject = GameObject.FindWithTag("Player");

        if(playerObject != null)
        {
            if(!passed && playerObject.transform.position.x > this.transform.position.x)
            {
                passed = true;
                mainGame.SendMessage("Score");
            }
        }
    }
}
