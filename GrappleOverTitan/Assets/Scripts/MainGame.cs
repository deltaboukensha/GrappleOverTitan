using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGame : MonoBehaviour
{
    public GameObject grapplingHookPrefab;
    public GameObject grapplingCablePrefab;
    public GameObject titanPrefab;
    public GameObject playerPrefab;
    public GameObject treeBranchPrefab;

    private GameObject grapplingHookObject;
    private GameObject grapplingCableObject;
    private GameObject grapplingHookObject2;
    private GameObject grapplingCableObject2;
    private float titanSpawnX = 15;
    private float treeSpawnX = 15;
    private float deadTime = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        var playerObject = GameObject.FindWithTag("Player");

        if(playerObject == null)
        {
            deadTime += Time.deltaTime;

            if(deadTime >= 2)
            {
                deadTime = 0;
                Instantiate(playerPrefab,
                    new Vector3(0, 0, 0),
                    Quaternion.identity
                );
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            if(playerObject != null)
            {
                grapplingHookObject = Instantiate(grapplingHookPrefab,
                    playerObject.transform.position,
                    Quaternion.LookRotation(
                        (Vector3)Camera.main.ScreenToWorldPoint(Input.mousePosition) - playerObject.transform.position, Vector3.forward)
                );
                grapplingHookObject.GetComponent<Rigidbody2D>()
                    .AddForce(Vector3.Normalize((Vector3)Camera.main.ScreenToWorldPoint(Input.mousePosition) - playerObject.transform.position) * Time.deltaTime * 2*1000000.0f);

                grapplingCableObject = Instantiate(grapplingCablePrefab,
                    playerObject.transform.position,
                    Quaternion.identity
                );
                var c = grapplingCableObject.GetComponent<GrapplingCable>();
                c.playerObject = playerObject;
                c.grapplingHookObject = grapplingHookObject;
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            if(grapplingHookObject != null)
            {
                Destroy(grapplingHookObject);
            }

            if(grapplingCableObject != null)
            {
                Destroy(grapplingCableObject);
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            if(playerObject != null)
            {
                grapplingHookObject2 = Instantiate(grapplingHookPrefab,
                    playerObject.transform.position,
                    Quaternion.LookRotation(
                        (Vector3)Camera.main.ScreenToWorldPoint(Input.mousePosition) - playerObject.transform.position, Vector3.forward)
                );
                grapplingHookObject2.GetComponent<Rigidbody2D>()
                    .AddForce(Vector3.Normalize((Vector3)Camera.main.ScreenToWorldPoint(Input.mousePosition) - playerObject.transform.position) * Time.deltaTime * 2*1000000.0f);

                grapplingCableObject2 = Instantiate(grapplingCablePrefab,
                    playerObject.transform.position,
                    Quaternion.identity
                );
                var c = grapplingCableObject2.GetComponent<GrapplingCable>();
                c.playerObject = playerObject;
                c.grapplingHookObject = grapplingHookObject2;
            }
        }

        if (Input.GetMouseButtonUp(1))
        {
            if(grapplingHookObject2 != null)
            {
                Destroy(grapplingHookObject2);
            }

            if(grapplingCableObject2 != null)
            {
                Destroy(grapplingCableObject2);
            }
        }
    }
}
