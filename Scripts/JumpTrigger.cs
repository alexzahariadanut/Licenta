using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpTrigger : MonoBehaviour {

    public AudioSource Scream;
    public GameObject ThePlayer;
    public GameObject JumpCamera;
    public GameObject FlashImg;

    void OnTriggerEnter ()
    {
        this.GetComponent<BoxCollider>().enabled = false;
        Scream.Play();
        JumpCamera.SetActive(true);
        ThePlayer.SetActive(false);
        FlashImg.SetActive(true);
        StartCoroutine(EndJump());

    }

    IEnumerator EndJump()
    {
        yield return new WaitForSeconds(2.03f);
        ThePlayer.SetActive(true);
        JumpCamera.SetActive(false);
        FlashImg.SetActive(false);

    }
}
