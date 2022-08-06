using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orb : MonoBehaviour
{
    private float life = 7f;

    void Awake()
    {
        Destroy(gameObject, life);
    }

    void Update()
    {
        if(SliderTimer.slider.value <= 0)
            Destroy(gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Catcher")
            Destroy(gameObject);
    }

}
