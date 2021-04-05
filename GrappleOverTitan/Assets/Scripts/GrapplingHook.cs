using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrapplingHook : MonoBehaviour
{
    private bool anchored = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(anchored)
        {
            var playerObject = GameObject.FindWithTag("Player");
            playerObject.GetComponent<Rigidbody2D>()
                .AddForce(Vector3.Normalize((this.transform.position - playerObject.transform.position)) * 10.0f);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("OnCollisionEnter2D");
        this.GetComponent<Rigidbody2D>().simulated = false;
        anchored = true;
    }
}