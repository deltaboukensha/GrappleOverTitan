using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    void Update()
    {
        var w = 8;
        
        if(this.transform.position.x - Camera.main.transform.position.x < -w)
        {
            this.transform.position = new Vector3(
                this.transform.position.x + w,
                this.transform.position.y,
                this.transform.position.z
            );
        }

        if(this.transform.position.x - Camera.main.transform.position.x > w)
        {
            this.transform.position = new Vector3(
                this.transform.position.x - w,
                this.transform.position.y,
                this.transform.position.z
            );
        }
    }
}
