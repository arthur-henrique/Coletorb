using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColetorbBegins : MonoBehaviour
{

    public GameObject logo;
    public GameObject[] menuText;
    public GameObject splashBackGround;
    public AudioSource bgm;
    public GameObject manager;
    public GameObject countDownText;
    public GameObject tapButton;
    public GameObject placarFinal;
    public GameObject catcher;
    public GameObject sliderObj;
    public GameObject highScore;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartUpGame());
    }

    IEnumerator StartUpGame()
    {
        yield return new WaitForSeconds(1);
        logo.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        logo.SetActive(false);
        menuText[0].SetActive(true);
        menuText[1].SetActive(true);
        highScore.GetComponent<Text>().text = "Melhor Placar: " + PlayerPrefs.GetInt("MelhorPlacar", 0).ToString();
        highScore.SetActive(true);
        tapButton.SetActive(true);

    }

    public void TapToStart()
    {
        tapButton.SetActive(false);
        menuText[0].SetActive(false);
        menuText[1].SetActive(false);
        highScore.SetActive(false);
        splashBackGround.GetComponent<Animator>().Play("SplashFadeOut");
        StartCoroutine(StartGame());
    }

    public void Mute()
    {
        bgm.mute = !bgm.mute;
    }

    IEnumerator StartGame()
    {
        catcher.GetComponent<Transform>().transform.position = new Vector3(0, -2.5f,0);
        //catcher.GetComponent<Transform>().transform.rotation = Quaternion.identity;
        Pontos.placar = 0; 
        placarFinal.SetActive(false);
        highScore.SetActive(false);
        sliderObj.SetActive(true);
        yield return new WaitForSeconds(1);
        splashBackGround.SetActive(false);
        bgm.Play();
        countDownText.SetActive(true);
        yield return new WaitForSeconds(1);
        countDownText.GetComponent<Text>().text = "2";
        yield return new WaitForSeconds(1);
        countDownText.GetComponent<Text>().text = "1";
        yield return new WaitForSeconds(1);
        countDownText.SetActive(false);
        countDownText.GetComponent<Text>().text = "3";
        manager.GetComponent<Timer>().enabled = true;
        manager.GetComponent<OrbGen>().enabled = true;
        manager.GetComponent<ObstaclesGen>().enabled = true;
        sliderObj.GetComponent<SliderTimer>().enabled = true;

    }

}
