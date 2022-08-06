using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbCatch : MonoBehaviour
{
    public AudioSource goldenOrbCatchFX;
    public AudioSource whiteOrbCatchFX;
    public AudioSource greyOrbCatchFX;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "GoldenOrb")
        {
            goldenOrbCatchFX.Play();
            Pontos.placar += 3;
            if(Pontos.placar <= 150)
                SliderTimer.slider.value += 0.03f;
        }
        if(other.tag == "WhiteOrb")
        {
            whiteOrbCatchFX.Play();
            Pontos.placar += 2;
            if(Pontos.placar <= 150)
                SliderTimer.slider.value += 0.02f;
        }
        if(other.tag == "GreyOrb")
        {
            greyOrbCatchFX.Play();
            Pontos.placar += 1;
            if(Pontos.placar <= 150)
                SliderTimer.slider.value += 0.01f;
        }

        if(Timer.isZero == false)
        {
            if(Pontos.placar <= 15)
                SliderTimer.slider.value += (0.1f * 1.5f);
            if(Pontos.placar > 15 && Pontos.placar <= 50)
                SliderTimer.slider.value += (0.1f * 1.35f);
            if(Pontos.placar > 50 && Pontos.placar <= 100)
                SliderTimer.slider.value += (0.1f * 1.1f);
            if(Pontos.placar > 100 && Pontos.placar <= 150)
                SliderTimer.slider.value += (0.1f);
            if(Pontos.placar > 150 && Pontos.placar <= 200)
                SliderTimer.slider.value += (0.09f);
            if(Pontos.placar > 200 && Pontos.placar <= 250)
                SliderTimer.slider.value += (0.08f);
            if(Pontos.placar > 250)
                SliderTimer.slider.value += (0.07f);
            
        }

            
    }
}
