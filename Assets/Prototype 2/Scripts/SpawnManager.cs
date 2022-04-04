using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20f;
    private float spawnRangeZ = 20f;
    private float startDelay = 2f;
    private float spawnInterval = 1.5f;
    private float spawnSide = 27f;

    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    void SpawnRandomAnimal()
    {
        // Randomly generate animal Index and spawn position 
        Vector3 spawnPosX = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangeZ);
        Vector3 spawnLeftSide = new Vector3(-spawnSide, 0, Random.Range(5f, 15f));
        Vector3 spawnRightSide = new Vector3(spawnSide, 0, Random.Range(5f, 15f));

        int animalIndex = Random.Range(0, animalPrefabs.Length);

        Instantiate(animalPrefabs[animalIndex], spawnPosX, animalPrefabs[animalIndex].transform.rotation);
        Instantiate(animalPrefabs[animalIndex], spawnLeftSide, Quaternion.Euler(0, 90, 0));
        Instantiate(animalPrefabs[animalIndex], spawnRightSide, Quaternion.Euler(0, -90, 0));

    }
}
