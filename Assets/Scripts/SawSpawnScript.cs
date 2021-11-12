using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawSpawnScript : MonoBehaviour
{
    public GameObject sawPrefab;
    float spawnIntervalTimer = 3f;
    public float spawnInterval = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CreatePrefab();
    }

    void CreatePrefab()
    {
        spawnIntervalTimer -= Time.deltaTime;

        if (spawnIntervalTimer <= 0)
        {
            spawnIntervalTimer = spawnInterval;
            Instantiate(sawPrefab, this.transform.position, Quaternion.identity);
        }
    }
}
