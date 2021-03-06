﻿ using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyPickup : MonoBehaviour {

    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject ExtraCross;
    public GameObject theKey;
    

	
	// Update is called once per frame
	void Update ()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;

	}
    void OnMouseOver()
    {
        if (TheDistance <= 1)
        {
            ExtraCross.SetActive(true);
            ActionText.GetComponent<Text>().text = "Pick up Key";
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);

        }
        if (Input.GetButtonDown("Action"))
        {
            if(TheDistance <=1)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                ExtraCross.SetActive(false);
                theKey.SetActive(false);
                GlobalInventory.firstDoorKey = true;
            }
        }
    }

    void OnMouseExit()
    {
        ExtraCross.SetActive(false);
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
    }

}
