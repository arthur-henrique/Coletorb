using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameObject timeBar;
    private RectTransform width;
    public static float timeBarWidth = 350f;
    public static bool isZero = false;
    public GameObject splashBackGround;
    public GameObject manager;
    public GameObject bgm;
    public GameObject tapButton;
    public GameObject placarFinal;
    public GameObject tapToBeginText;
    public GameObject sliderObj;

    // Start is called before the first frame update
    void Start()
    {
        width = timeBar.GetComponent<RectTransform>();

    }

    // Update is called once per frame
    void Update()
    {
        if(!isZero)
            width.sizeDelta = new Vector2(timeBarWidth -= Time.deltaTime*35f, 225.0f);


        if(SliderTimer.slider.value <= 0)
            isZero = true;

        if(isZero == true)
        {
            StartCoroutine(GameOver());
            isZero = false;
            SliderTimer.slider.value += 1f;
        }

        IEnumerator GameOver()
        {
            splashBackGround.SetActive(true);
            manager.GetComponent<OrbGen>().enabled = false;
            manager.GetComponent<Timer>().enabled = false;
            sliderObj.GetComponent<SliderTimer>().enabled = false;
            sliderObj.SetActive(false);
            manager.GetComponent<ObstaclesGen>().enabled = false;
            bgm.SetActive(false);
            splashBackGround.GetComponent<Animator>().Play("SplashFadeIn");
            yield return new WaitForSeconds(1.2f);
            placarFinal.GetComponent<Text>().text = "Placar: " + Pontos.placar;
            placarFinal.SetActive(true);
            tapToBeginText.SetActive(true);
            yield return new WaitForSeconds(1);
            tapButton.SetActive(true);
            

        }
    }

}
