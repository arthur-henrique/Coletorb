using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    protected virtual void Spawn(Obst obstacle, Transform spawnSpot)
    {
        var _obstacle = Instantiate(obstacle, spawnSpot.position, Quaternion.identity);
    }
}
