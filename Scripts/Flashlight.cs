using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour {

 
    public AudioSource soundOn;
    public AudioSource soundOff;
    


    void Update ()
    {
		if(Input.GetKeyDown(KeyCode.Mouse1))
        {
           if(GetComponent<Light>().enabled == false )
            {
                GetComponent<Light>().enabled = true;
                soundOn.Play();
                    
            }
           else
            {
                GetComponent<Light>().enabled = false;
                soundOff.Play();
               
            }


        }
        

    }
}
