using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] fishyPrefabs;
    public ParticleSystem splashParticle;
    private float zRange = 12;
    private float rightRangeX = 38;
    private float leftRangeX = -37;

    private float spawnInterval;
    private float startDelay = 1;

    // Start is called before the first frame update
    void Start()
    {
        spawnInterval = Random.Range(7, 10);
        InvokeRepeating("SpawnRandomFish", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomFish()
    {
        Vector3 spawnPos = new Vector3(Random.Range(leftRangeX, rightRangeX), 1, Random.Range(-zRange, zRange));
        int fishIndex = Random.Range(0, fishyPrefabs.Length);
        Instantiate(fishyPrefabs[fishIndex], spawnPos, fishyPrefabs[fishIndex].transform.rotation);
        Instantiate(splashParticle, spawnPos, splashParticle.transform.rotation);
        splashParticle.Play();
    }
}
