using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject bloodPrefab;
    public GameObject headPrefab;
    public GameObject footPrefab;
    public GameObject bodyPrefab;
    public GameObject swordPrefab;

    void OnCollisionEnter2D(Collision2D collision)
    {
        var isDeadlyCollision = collision.collider.gameObject.layer == LayerMask.NameToLayer("Deadly");

        if(isDeadlyCollision)
        {
            Destroy(this.gameObject);
            var bloodObject = Instantiate(bloodPrefab,
                this.transform.position,
                Random.rotation
            );
            
            var head = Instantiate(headPrefab,
                this.transform.position,
                Random.rotation
            );
            head.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f)) * 100);
            
            var foot1 = Instantiate(footPrefab,
                this.transform.position,
                Random.rotation
            );
            foot1.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f)) * 100);

            var foot2 = Instantiate(footPrefab,
                this.transform.position,
                Random.rotation
            );
            foot2.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f)) * 100);
            
            var body = Instantiate(bodyPrefab,
                this.transform.position,
                this.transform.rotation
            );
            body.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f)) * 100);
            
            var sword1 = Instantiate(swordPrefab,
                this.transform.position,
                this.transform.rotation
            );
            sword1.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f)) * 100);

            var sword2 = Instantiate(swordPrefab,
                this.transform.position,
                this.transform.rotation
            );
            sword2.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f)) * 100);
        }
    }
}
