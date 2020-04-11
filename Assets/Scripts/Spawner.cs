using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] enemies;
    public float spawnTime = 1f;
    int randomSpawnPoint, randomEnemy;
    public static bool spawnAllowed;


    private void Start()
    {
        spawnAllowed = true;
        InvokeRepeating("Spawn", 1f, spawnTime);
    }


    public void Spawn()
    {
        if(spawnAllowed)
        {
            randomSpawnPoint = Random.Range(0, spawnPoints.Length);
            randomEnemy = Random.Range(0, enemies.Length);
            Instantiate(enemies[randomEnemy], spawnPoints [randomSpawnPoint].position, Quaternion.identity);
        }
    }

}
