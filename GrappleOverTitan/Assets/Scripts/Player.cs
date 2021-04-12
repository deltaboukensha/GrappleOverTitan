using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject bloodPrefab;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Titan" || collision.gameObject.tag == "Ground")
        {
            Destroy(this.gameObject);
            var bloodObject = Instantiate(bloodPrefab,
                this.transform.position,
                this.transform.rotation
            );
        }
    }
}
