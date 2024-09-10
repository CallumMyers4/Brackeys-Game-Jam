using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawnerScript : MonoBehaviour
{
    public GameObject obstacle;
    [SerializeField] private MainPlayerScript player;
    public float maxX, minX, maxY, minY;
    public float minTime, maxTime;
    private float spawnTime, timeBetweenSpawn;

    void Start()
    {
        timeBetweenSpawn = Random.Range(minTime, maxTime);
        spawnTime = Time.time + timeBetweenSpawn;
    }
    // Update is called once per frame
    void Update()
    {
        if (Time.time > spawnTime && !player.dead)
        {
            Spawn();
            timeBetweenSpawn = Random.Range(minTime, maxTime);
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }

    void Spawn()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY,maxY);

        Instantiate(obstacle, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }
}
