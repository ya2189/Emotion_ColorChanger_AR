using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchScript : MonoBehaviour {

	// Update is called once per frame
	void Update () {
        //Touch t = Input.GetTouch(0); //first touch, Touch is a struct
        //phase=begin,moving,stationary,ended<-picked finger off the screen
            //position of touch on screen
	}

    void OnGUI()
    {
        foreach(Touch touch in Input.touches)
        {
            string message = "";
            message += "ID: " + touch.fingerId + "\n";
            message += "Phase: " + touch.phase.ToString() + "\n";
            message += "Pos X: " + touch.position.x + "\n";
            message += "Pos Y: " + touch.position.y + "\n";

            int num = touch.fingerId; //offset so messages dont overlap
            GUI.Label(new Rect(0 + 130 + num, 0, 120, 100), message);
        }
    }
}
