using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrapplingCable : MonoBehaviour
{
    public GameObject playerObject;
    public GameObject grapplingHookObject;
    private Vector3[] points = new Vector3[2];

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(playerObject != null && grapplingHookObject != null)
        {
            points[0] = playerObject.transform.position;
            points[1] = grapplingHookObject.transform.position;
            this.GetComponent<LineRenderer>().SetPositions(points);
        }
    }
}
