using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbGen : MonoBehaviour
{
    public Orb[] orbs;
    public OrbThrower[] thrower;
    public bool canGenOrb = false;
    public float genCD = 1.5f;

    private int randomShooter;
    private int randomOrb;

    void Update()
    {   
        if (!canGenOrb)
        {
            canGenOrb = true;
            randomShooter = Random.Range(0, 4);
            randomOrb = Random.Range(0, 3);
            
            StartCoroutine(OrbFalling());
        }
    }

    IEnumerator OrbFalling()
    {
        for (int i = 0; i < 4; i++)
        {
            if(i == randomShooter)
            {
                thrower[i].Throw(orbs[randomOrb]);
                yield return new WaitForSeconds(genCD);
            }
        }
        canGenOrb = false;
        if(Pontos.placar>=15)
            genCD = 1.35f;
        if(Pontos.placar>50)
            genCD = 1.10f;
        if(Pontos.placar>100)
            genCD = 0.9f;
        if(Pontos.placar>150)
            genCD = 0.80f;
        if(Pontos.placar>200)
            genCD = 0.70f;
        if(Pontos.placar>250)
            genCD = 0.6f;
    }
}
