using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
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
            this.transform.position = new Vector3(
                playerObject.transform.position.x,
                playerObject.transform.position.y,
                this.transform.position.z
            );
        }
    }
}
