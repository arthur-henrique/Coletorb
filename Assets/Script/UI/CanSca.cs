using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanSca : MonoBehaviour
{
    private CanvasScaler canvas;
    
    public float resX;
    public float resY;

    void Start()
    {
        canvas = GetComponent<CanvasScaler>();
        ScaleScreen();
    }

    private void ScaleScreen()
    {
        resX = (float)Screen.currentResolution.width;
        resY = (float)Screen.currentResolution.height;

        canvas.referenceResolution = new Vector2 (resX, resY);
    }

}
