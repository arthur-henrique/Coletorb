using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orb : MonoBehaviour, IPooledObject
{

    public float upForce = 10f;
    public float sideForce = 2f;

    public void OnObjectSpawn()
    {
        float xForce = Random.Range(-sideForce, sideForce);
        float yForce = Random.Range(upForce / 2f, upForce);

        Vector3 force = new Vector3 (xForce, yForce, 0);
        GetComponent<Rigidbody>().velocity = force;
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Catcher")
        {
            gameObject.SetActive(false);
        }
        if(other.tag == "Collector")
        {
            gameObject.SetActive(false);
        }
    }

}
