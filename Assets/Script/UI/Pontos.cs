using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Pontos : MonoBehaviour
{
    public GameObject placarPontos;
    public GameObject PlacarPainel;
    public static int placar;

    private void Update()
    {
        placarPontos.SetActive(true);
        PlacarPainel.SetActive(true);
        placarPontos.GetComponent<Text>().text = "Placar: " + placar; 
    }

    protected virtual void MelhorPlacar()
    {
        if(placar > PlayerPrefs.GetInt("MelhorPlacar", 0))
            PlayerPrefs.SetInt("MelhorPlacar", placar);        
    }
}
