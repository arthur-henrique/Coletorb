using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obst : MonoBehaviour
{
    private float life = 4f;
    public  int hits = 3;

    void Awake()
    {
        Destroy(gameObject, life);
    }

    void Update()
    {
        if(SliderTimer.slider.value <= 0)
            Destroy(gameObject);
    }
}
