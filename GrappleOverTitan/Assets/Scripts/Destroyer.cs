using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    void Update()
    {
        var playerObject = GameObject.FindWithTag("Player");
        if(playerObject != null)
        {
            this.transform.position = new Vector3(
                Mathf.Max(this.transform.position.x, playerObject.transform.position.x - 100),
                this.transform.position.y,
                this.transform.position.z
            );
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(other.gameObject);
    }
}
