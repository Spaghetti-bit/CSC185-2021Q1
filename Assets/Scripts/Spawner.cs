using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawnGameObject;
    [Range(1, 10)] public float spawnTimeMin;
    [Range(1, 10)] public float spawnTimeMax;



    float spawnTimer;

    // Start is called before the first frame update
    void Start()
    {
        if(spawnTimeMin > spawnTimeMax)
        {
            float temp = spawnTimeMin;
            spawnTimeMin = spawnTimeMax;
            spawnTimeMax = spawnTimeMin;
        }

        spawnTimer = Random.Range(spawnTimeMin, spawnTimeMax);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.childCount == 0)
        {
            spawnTimer -= Time.deltaTime;
        }
        if(spawnTimer <= 0)
        {
            Instantiate(spawnGameObject, transform);
            spawnTimer = Random.Range(spawnTimeMin, spawnTimeMax);
        }

        
    }
}
