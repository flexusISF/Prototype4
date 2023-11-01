using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float spawnRange;
    // Start is called before the first frame update
    void Start()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        //return randomPos;
        Instantiate(enemyPrefab, new Vector3(0, 0, 6), enemyPrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
