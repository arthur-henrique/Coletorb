using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderTimer : MonoBehaviour
{
    public static Slider slider;
    private ParticleSystem particleSyst;

    private float targetValue = 4f;
    public float fillSpeed = 0.4f;

    private void Awake()
    {
        slider = gameObject.GetComponent<Slider>();
        //particleSyst = GameObject.Find("ParticleEffects").GetComponent<ParticleSystem>();
    }

    void Start()
    {
        DecreaseValue(1.0f);
    }

    void Update()
    {
        if(slider.value > targetValue)
        {
            slider.value -= fillSpeed * Time.deltaTime;
            /*
            if(!particleSyst.isPlaying)
                particleSyst.Play();
        }
        else
        {
            particleSyst.Stop();*/
        }
    }

    public void DecreaseValue(float newValue)
    {
        targetValue = slider.value - newValue;
    }
}
