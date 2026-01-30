using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject groundPipe;
    [SerializeField] private GameObject ceilingPipe;
    private float spawnHeight;
    private float timer;
    [SerializeField] private float spawnCoolDown;


    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnCoolDown)
        {
            SpawnPipe();
        }

    }

    private void SpawnPipe()
    {
        spawnHeight = Random.Range(-3f, -.7f);
        Vector2 spawnLocation = new Vector2(transform.position.x, spawnHeight);
        Instantiate(groundPipe, spawnLocation, Quaternion.identity);

        Vector2 spawnLocationB = new Vector2(spawnLocation.x, spawnLocation.y + 7.5f);
        Instantiate(ceilingPipe, spawnLocationB, Quaternion.identity);

        timer = 0f;
    }
}
