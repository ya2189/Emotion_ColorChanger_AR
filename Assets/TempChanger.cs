using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempChanger : MonoBehaviour {

    public GameObject cameraPlane;
    public Color myColor = new Vector4(0.0f, 0.0f, 0.0f, 0.0f);

    public void changeColorToBlue()
    {
        // Color myColor = new Vector4(0.3f, 0.4f, 0.5f, 0.2f);
        myColor.a = 0.05f;
        cameraPlane.GetComponent<Renderer>().sharedMaterial.color = myColor;
        if (!((myColor.b == 0.98f) && (myColor.g == 0.56f) && (myColor.r == 0.02f)))
        {

            myColor.b += 0.02f;
         
            if (myColor.g < 0.56)
            {
                myColor.g += 0.02f;
            }
            else
            {
                myColor.g -= 0.02f;
            }
            
            myColor.r -= 0.02f;
           
        }

      
    }

    public void changeColorToOrange()
    {
        myColor.a = 0.05f;
        cameraPlane.GetComponent<Renderer>().sharedMaterial.color = myColor;
        if (!((myColor.b == 0.02f) && (myColor.g == 0.54f) && (myColor.r == 0.98f)))
        {
            
            myColor.b -= 0.02f;
            
            if (myColor.g < 0.54)
            {
                myColor.g += 0.02f;
            }
            else
            {
                myColor.g -= 0.02f;
            }

            myColor.r += 0.02f;
         

        }


    }
}
