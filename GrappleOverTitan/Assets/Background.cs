using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public GameObject background1;
    public GameObject background2;
    public GameObject background3;

    void Update()
    {   
        var playerObject = GameObject.FindWithTag("Player");

        if(playerObject != null)
        {
            if(background1.GetComponent<BoxCollider2D>().bounds.Contains(playerObject.transform.position))
            {
                background3.transform.position = new Vector3(
                    background1.transform.position.x - background1.GetComponent<BoxCollider2D>().size.x,
                    background3.transform.position.y,
                    background3.transform.position.z
                );

                background2.transform.position = new Vector3(
                    background1.transform.position.x + background1.GetComponent<BoxCollider2D>().size.x,
                    background2.transform.position.y,
                    background2.transform.position.z
                );
            }

            if(background2.GetComponent<BoxCollider2D>().bounds.Contains(playerObject.transform.position))
            {
                background1.transform.position = new Vector3(
                    background2.transform.position.x - background2.GetComponent<BoxCollider2D>().size.x,
                    background1.transform.position.y,
                    background1.transform.position.z
                );

                background3.transform.position = new Vector3(
                    background2.transform.position.x + background2.GetComponent<BoxCollider2D>().size.x,
                    background3.transform.position.y,
                    background3.transform.position.z
                );
            }

            if(background3.GetComponent<BoxCollider2D>().bounds.Contains(playerObject.transform.position))
            {
                background2.transform.position = new Vector3(
                    background3.transform.position.x - background3.GetComponent<BoxCollider2D>().size.x,
                    background2.transform.position.y,
                    background2.transform.position.z
                );

                background1.transform.position = new Vector3(
                    background3.transform.position.x + background3.GetComponent<BoxCollider2D>().size.x,
                    background1.transform.position.y,
                    background1.transform.position.z
                );
            }
        }
    }
}
