using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catcher : MonoBehaviour
{

    private Touch touch;
    Vector3 currentAngles;
    Vector3 limitAngles;
    Quaternion currentRotation;
    private float speedMod = 0.0075f;
    private float flutMod = 0.002f;
    private float zSwing = 0.08f;
    
    // Update is called once per frame
    void Update()
    {
        /*
        Vector3 relativePos = alvo.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePos); 
        Quaternion current = transform.localRotation;

        transform.localRotation = Quaternion.Slerp(current, rotation, Time.deltaTime);
        transform.Translate(0,0,3*Time.deltaTime);
        */

        if(Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Moved)
            {
                if(transform.position.x >=0)
                {
                    transform.position = new Vector3(transform.position.x + touch.deltaPosition.x * speedMod,
                    transform.position.y + touch.deltaPosition.x * flutMod,
                    transform.position.z);
                    /*
                    currentAngles += new Vector3(0, 0, touch.deltaPosition.x * zSwing);
                    currentRotation.eulerAngles = currentAngles;
                    transform.rotation = currentRotation;
                    */

                    if(transform.position.x > 1.3f)
                    {
                        transform.position = new Vector3(1.3f, -2.16f, transform.position.z);
                        //currentAngles = new Vector3(0,0, 15);
                    }
                }
                if(transform.position.x <0)
                {
                    if(touch.position.x > transform.position.x && touch.deltaPosition.x > 0 )
                    { 
                        transform.position = new Vector3(transform.position.x + touch.deltaPosition.x * speedMod,
                        transform.position.y - touch.deltaPosition.x * flutMod,
                        transform.position.z);
                        /*
                        currentAngles += new Vector3(0, 0, touch.deltaPosition.x * zSwing);
                        currentRotation.eulerAngles = currentAngles;
                        transform.rotation = currentRotation;
                        */
                    }
                    if(touch.deltaPosition.x < transform.position.x && transform.position.x <= 0)
                    {
                        transform.position = new Vector3(transform.position.x + touch.deltaPosition.x * speedMod,
                        transform.position.y - touch.deltaPosition.x * flutMod,
                        transform.position.z);
                        /*
                        currentAngles += new Vector3(0, 0, touch.deltaPosition.x * zSwing);
                        currentRotation.eulerAngles = currentAngles;
                        transform.rotation = currentRotation;
                        */

                        if (transform.position.x <= -1.3f)
                        {
                            transform.position = new Vector3(-1.3f, -2.16f, transform.position.z);
                            //currentAngles = new Vector3(0,0, -15);
                        }
                    }
                }

                if(transform.position.y < -2.5f)
                {
                    transform.position = new Vector3(transform.position.x, -2.5f, transform.position.z);
                }
            }
        }

    }
}
