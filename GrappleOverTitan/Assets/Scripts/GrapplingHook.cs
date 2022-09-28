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
        var playerObject = GameObject.FindWithTag("Player");

        if (playerObject != null)
        {
            if (anchored)
            {
                playerObject.GetComponent<Rigidbody2D>()
                    .AddForce(Vector3.Normalize((this.transform.position - playerObject.transform.position)) * Time.deltaTime * 2000.0f);
            }
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        this.GetComponent<Rigidbody2D>().simulated = false;
        anchored = true;
    }
}
