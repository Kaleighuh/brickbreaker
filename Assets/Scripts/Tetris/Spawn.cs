using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Spawn : MonoBehaviour
{
    public GameObject[] cubePrefabs;
    public float speed = 1f;
    public GameObject destroyerObject;
    public UnityEvent ScoreEvent;

    List<GameObject> spawnedCubes = new List<GameObject>();
    //public Score score;

    void Start()
    {
        InvokeRepeating("SpawnRandomCube", 1f, speed);
        //spawnerStats.CubeSpawned(); 
    }

    void SpawnRandomCube() {
        if(spawnedCubes.Count >= 10) {
            Destroy(spawnedCubes[0]); 
            spawnedCubes.RemoveAt(0);
        }
       
        
        int index = Random.Range(0, cubePrefabs.Length);

        Quaternion rot = Quaternion.Euler(90f, 0, 0);
        Vector3 spawnPos = new Vector3(Random.Range(-4f, 4f), transform.position.y, transform.position.z); 
        GameObject obj = Instantiate(cubePrefabs[index], spawnPos, Quaternion.identity); 
        spawnedCubes.Add(obj);
    }

}