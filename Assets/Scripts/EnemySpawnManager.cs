using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    [SerializeField] GameObject[] enemyPrefabs;
    private float spawnRangX = 60.0f;
    private float spawnPosY = 20.0f;
    private float startDelay = 2.0f;
    private float spawnInterval = 8.0f;
    public GameObject spaceShip;



    // Start is called before the first frame update
    void Start()
    {
        spaceShip = GameObject.Find("Player");
        InvokeRepeating("SpawnRandomEnemy", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.S))
        {
            //SpawnRandomAnimal();
        }
    }

    void SpawnRandomEnemy()
    {
        int enemyIndex = Random.Range(0, enemyPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(30.0f + spaceShip.transform.position.x, spawnRangX+ spaceShip.transform.position.x), Random.Range(-spawnPosY+ spaceShip.transform.position.x, spawnPosY+ spaceShip.transform.position.x), 0.0f);

        Instantiate(enemyPrefabs[enemyIndex], spawnPos, enemyPrefabs[enemyIndex].transform.rotation);
    }
}
