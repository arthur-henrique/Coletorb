using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbThrower : MonoBehaviour
{
    public Transform launchPoint;
    public GameObject orb;
    private float orbVelocity = 10f;


    virtual public void Throw(Orb orb)
    {
        var _orb = Instantiate(orb, launchPoint.position, Quaternion.identity);
        _orb.GetComponent<Rigidbody>().velocity = launchPoint.up * orbVelocity;
    }
}
