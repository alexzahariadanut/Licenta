using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CellExitDoor : MonoBehaviour {

    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject ExtraCross;
    //public AudioSource CreakSound;
    public GameObject fadeOut;

	
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
                fadeOut.SetActive(true);
                StartCoroutine(FadeToExit());
                //TheDoor.GetComponent<Animation>().Play("FirstDoorOpenAnim");
               // CreakSound.Play();
            }
        }
    }

    void OnMouseExit()
    {
        ExtraCross.SetActive(false);
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
    }

    IEnumerator FadeToExit()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(4);
    }
}
