using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeSpawner : MonoBehaviour
{
    public GameObject tree;

    private float timeBtwSpawn;
    public float StartTimeBtwSpawn;
    private Vector3 SpawnPos;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        SpawnPos = new Vector3(transform.position.x,transform.position.y, transform.position.z);
        if (timeBtwSpawn <= 0)
        {
            Instantiate(tree, SpawnPos, transform.rotation);
            timeBtwSpawn = StartTimeBtwSpawn;
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}
