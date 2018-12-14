using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class changeTemperature : MonoBehaviour {

    //This camera will be used when I implement the "emoticon buttons"
   // public Camera camera;
    public GameObject cameraPlane; //plane attached to the first Person Camera
    public Color myColor = new Vector4(0.0f, 0.0f, 0.0f, 0.0f);
    private string emotion = "happy"; //string that holds the current emotion the user pressed; default emotion is set to "happy"

    //Still working on the "emoticon buttons" functionality
    /* void Start()
     {
         RaycastHit hit;
         Ray ray = camera.ScreenPointToRay(Input.mousePosition);

         if (Physics.Raycast(ray, out hit))
         {
             Transform objectHit = hit.transform;

             if (objectHit.tag == "Happy")
             {
                 emotion = "happy";
             }
             else if (objectHit.tag == "Sad")
             {
                 emotion = "sad";
             }
             else if (objectHit.tag == "Angry")
             {
                 emotion = "angry";
             }



             // Do something with the object that was hit by the raycast.
         }
     }*/

    // Every frame, check what button the user pressed and set the emotion string to the correct emotion
    void Update()
        {
            //checks the tag of the gameobject to see which button the user pressed
            if (EventSystem.current.currentSelectedGameObject != null && EventSystem.current.currentSelectedGameObject.tag == "Happy")
            {
                emotion= "happy";
            }
            else if (EventSystem.current.currentSelectedGameObject != null && EventSystem.current.currentSelectedGameObject.tag == "Sad")
            {
                emotion = "sad";
            }
            else if (EventSystem.current.currentSelectedGameObject != null && EventSystem.current.currentSelectedGameObject.tag == "Angry")
            {
                emotion = "angry";
            }
        

    }

    /* PURPOSE: method that changes the color parameters (a,r,g,b) of the plane attached to the camera to "tint" the camera
     * 
     * PARAMS: float red- the goal red RGB value for the emotion
     *         float green- the goal green RGB value for the emotion
     *         float blue- the goal blue RGB value for the emotion
     */
    public void changeColor(float red, float green, float blue)
    {
       
        myColor.a = 0.3f;
        cameraPlane.GetComponent<Renderer>().sharedMaterial.color = myColor;

        if (myColor.r > red)
        {
            myColor.r -= 0.04f;

        } else if (myColor.r < red) 
        {
            myColor.r += 0.04f;
        }

        if (myColor.g > green)
        {
            myColor.g -= 0.04f;
        } else if (myColor.g < green)
        {
            myColor.g += 0.04f;
        }
     
        if (myColor.b < blue)
        {
            myColor.b += 0.04f;
        } else if (myColor.b > blue)
        {
            myColor.b -= 0.04f;
        }

    }

    /* PURPOSE: method that calls the changeColor method (according to which
     * emotion the variable 'emotion' is set to) to change
     * the color of the plane. The goal/final RGB values for the 
     * corresponding emotion are passed into the changeColor method.
     * I got these RGB values from this site: https://www.quackit.com/css/css_color_codes.cfm
     * and just divided the values by 255 to get floats.
     * 
     * PARAMS: none
     */
    public void color_change() { 

        if (emotion.Equals("happy"))
        {
            changeColor(0.96f, 0.88f, 0.00f);
        }
        else if (emotion.Equals("sad")) 
        {
            changeColor(0.00f, 0.32f, 0.96f);
        }
        else if (emotion.Equals("angry"))
        {
            changeColor(0.96f, 0.04f, 0.00f);
        }
}

}
