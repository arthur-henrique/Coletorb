using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchFunctios : MonoBehaviour
{

    public bool activePlat = false;
    public AudioSource platActiveFX;
    public static float cd = 0.5f;

    public void PlatformActivation(GameObject plat)
    {
        if (!activePlat){
            plat.SetActive(true);
            platActiveFX.Play();
            StartCoroutine(PlatformReset(plat));
            activePlat = true;
        }
    }

    IEnumerator PlatformReset(GameObject plat)
    {
        yield return new WaitForSeconds(cd);
        plat.SetActive(false);
        activePlat = false;
    }
}
