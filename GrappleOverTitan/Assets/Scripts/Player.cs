using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject bloodPrefab;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "titan" || collision.gameObject.tag == "ground")
        {
            Debug.Log("Destroy");
            // Destroy(this.gameObject);
            // var bloodObject = Instantiate(bloodPrefab,
            //     this.transform.position,
            //     this.transform.rotation
            // );
        }
    }
}
