using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    private float spawnTimer = 5f;

    public int dif = 0;

    public Transform spawnLocation;
    public GameObject ballPrefab;

	// Use this for initialization
	void Start () {
        dif = 0;
	}
	
	// Update is called once per frame
	void Update () {
        CreateBall();
	}

    void CreateBall()
    {
        spawnTimer -= Time.deltaTime;
        if (spawnTimer <= 0)
        {
            if (dif <= 5)
            {

                Instantiate(ballPrefab, spawnLocation.position, Quaternion.identity);
                spawnTimer = 15f;
                dif++;
            } else if (dif <= 10)
            {
                Instantiate(ballPrefab, spawnLocation.position, Quaternion.identity);
                spawnTimer = 10f;

            } else if (dif <= 15)
            {
                Instantiate(ballPrefab, spawnLocation.position, Quaternion.identity);

                spawnTimer = 5f;

            } else if (dif <= 20)
            {
                Instantiate(ballPrefab, spawnLocation.position, Quaternion.identity);
                spawnTimer = 3f;

            }


        }



    }


}
