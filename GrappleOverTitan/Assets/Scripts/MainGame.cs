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
    private float titanSpawnX = 15;
    private float treeSpawnX = 15;
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        var playerObject = GameObject.FindWithTag("Player");

        if (Input.GetMouseButtonDown(0))
        {
            if(playerObject != null)
            {
                grapplingHookObject = Instantiate(grapplingHookPrefab, playerObject.transform.position, playerObject.transform.rotation);
                grapplingHookObject.GetComponent<Rigidbody2D>()
                    .AddForce(Vector3.Normalize((Vector3)Camera.main.ScreenToWorldPoint(Input.mousePosition) - playerObject.transform.position) * 4000.0f);
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            if(grapplingHookObject != null)
            {
                Destroy(grapplingHookObject);
            }
        }

        if(playerObject != null && playerObject.transform.position.x + 20 >= titanSpawnX)
        {
            var titanObject = Instantiate(titanPrefab,
                new Vector3(titanSpawnX, Random.value * 4 - 10, 0),
                Quaternion.identity);

            titanSpawnX += 5 + Random.value * 5;
        }

        if(playerObject != null && playerObject.transform.position.x + 20 >= treeSpawnX)
        {
            var treeBranchObject = Instantiate(treeBranchPrefab,
                new Vector3(treeSpawnX, 5 - Random.value * 4, 0),
                Quaternion.identity);

            treeSpawnX += 5 + Random.value * 5;
        }

        if(playerObject != null)
        {
            score = (int)Mathf.Max(score, playerObject.transform.position.x);

            var scoreObject = GameObject.FindWithTag("Score");
            if(scoreObject != null)
            {
                scoreObject.GetComponent<TMPro.TextMeshProUGUI>().text = "" + score;
            }
        }
    }
}
