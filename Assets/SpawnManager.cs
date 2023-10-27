using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] popPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomPop", startDelay, spawnInterval); 
    }
    // Update is called once per frame
    void Update()
    {
       
    }
    void SpawnRandomPopl() 
    {
        int popIndex = Random.Range(0, popPrefabs.Length); 
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),0, spawnPosZ);
        Instantiate(popPrefabs[popIndex], spawnPos, popPrefabs[popIndex].transform.rotation); 
    }  
}
