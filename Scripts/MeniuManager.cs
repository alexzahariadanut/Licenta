using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MeniuManager : MonoBehaviour {

    public GameObject fadeOut;
    public GameObject loadText1;
    public GameObject loadText2;
    public GameObject loadText3;
    public AudioSource buttonClick;
    public int count = 0;

    public void NewGameButton()
    {
        StartCoroutine(NewGameStart());
    }

    IEnumerator NewGameStart()
    {
        fadeOut.SetActive(true);
        buttonClick.Play();
        yield return new WaitForSeconds(3);

		loadText1.SetActive(true);
        yield return new WaitForSeconds(1);
        loadText1.SetActive(false);
        loadText2.SetActive(true);
        yield return new WaitForSeconds(1);
        loadText2.SetActive(false);
        loadText3.SetActive(true);
        yield return new WaitForSeconds(1);
        loadText3.SetActive(false);

        loadText1.SetActive(true);
        yield return new WaitForSeconds(1);
        loadText1.SetActive(false);
        loadText2.SetActive(true);
        yield return new WaitForSeconds(1);
        loadText2.SetActive(false);
        loadText3.SetActive(true);
        yield return new WaitForSeconds(1);
        loadText3.SetActive(false);

        loadText1.SetActive(true);
        yield return new WaitForSeconds(1);
        loadText1.SetActive(false);
        loadText2.SetActive(true);
        yield return new WaitForSeconds(1);
        loadText2.SetActive(false);
        loadText3.SetActive(true);
        loadText3.SetActive(false);

        SceneManager.LoadScene(1);




    }
}
