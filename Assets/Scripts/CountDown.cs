using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CountDown : MonoBehaviour
{

    public GameObject CountDownUI;
    public AudioSource GetReady;
    public GameObject LapTimer;
    public GameObject CarControls;

    void Start()
    {
        StartCoroutine(CountStart());        
    }

    IEnumerator CountStart()
    {
        yield return new WaitForSeconds(0.5f); //wait for half sec

        CountDownUI.GetComponent<Text>().text = "3";
        GetReady.Play();
        CountDownUI.SetActive(true);

        yield return new WaitForSeconds(1f);
        CountDownUI.SetActive(false);
        CountDownUI.GetComponent<Text>().text = "2";
        CountDownUI.SetActive(true);

        yield return new WaitForSeconds(1f);
        CountDownUI.SetActive(false);
        CountDownUI.GetComponent<Text>().text = "1";
        CountDownUI.SetActive(true);
        yield return new WaitForSeconds(1f);
        CountDownUI.SetActive(false);

        LapTimer.SetActive(true);
        CarControls.SetActive(true);

    }


}
