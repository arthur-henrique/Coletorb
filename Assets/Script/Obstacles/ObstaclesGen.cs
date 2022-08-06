using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesGen : Obstacle
{
    public Obst[] obstacles;
    public Transform[] spawnPoints;
    public bool canGenObstacle;

    private int randomShape;
    private int randomSpot;

    void Update()
    {
        if(!canGenObstacle)
        {
            canGenObstacle = true;
            randomShape = Random.Range(0, 4);
            randomSpot = Random.Range(0, 4);

            StartCoroutine(SpawnObstacle());
        }
    }

    IEnumerator SpawnObstacle()
    {
        yield return new WaitForSeconds(5f);
        for (int i = 0; i < 5; i++)
        {
            if(i == randomShape)
            {
                Spawn(obstacles[i], spawnPoints[randomSpot]);
                yield return new WaitForSeconds(1f);
            }
        }
        canGenObstacle = false;
    }

}
