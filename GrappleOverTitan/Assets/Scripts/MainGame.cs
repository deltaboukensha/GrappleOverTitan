using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGame : MonoBehaviour
{
    public GameObject grapplingHookPrefab;
    public GameObject titanPrefab;
    public GameObject playerPrefab;
    public GameObject treeBranchPrefab;

    private GameObject grapplingHookObject;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if(hit.collider != null)
            {
                Debug.Log("hit");
                var playerObject = GameObject.FindWithTag("Player");
                
                if(playerObject != null)
                {
                    Debug.DrawLine(playerObject.transform.position, hit.point, Color.white, 2.5f);

                    grapplingHookObject = Instantiate(grapplingHookPrefab, playerObject.transform.position, playerObject.transform.rotation);
                    grapplingHookObject.GetComponent<Rigidbody2D>()
                        .AddForce(Vector3.Normalize((Vector3)hit.point - playerObject.transform.position) * 2000);
                }
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            if(grapplingHookObject != null)
            {
                Destroy(grapplingHookObject);
            }
        }
    }
}
