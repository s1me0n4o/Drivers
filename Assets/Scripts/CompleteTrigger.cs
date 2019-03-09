using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CompleteTrigger : MonoBehaviour
{
    public GameObject EndPointTrigger;
    public GameObject CompleteLevelUI;
    public GameObject YouWin;
    public GameObject YouLose;
    private string objectType = "Player01";

    public GameObject RaceFinish;


   
    void OnTriggerEnter(Collider Other)
    {
        CompleteLevelUI.SetActive(true);

        if (Other.tag == objectType)
        {
            YouWin.SetActive(true);
            YouLose.SetActive(false);
            RaceFinish.SetActive(true);
            Coins.TotalCash += (10 / 3);

            StartCoroutine(MainMenu());
        }
        else
        {
            YouLose.SetActive(true);
            YouWin.SetActive(false);
            RaceFinish.SetActive(true);

            if (Coins.TotalCash >= 10)
            {
                Coins.TotalCash -= (10 / 3);
            }

            StartCoroutine(MainMenu());

        }
    }
    
    IEnumerator MainMenu()
    {

        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(0);

    }
}
