using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectACar : MonoBehaviour
{

    public static int CarType;
    public GameObject TraceOne;
    public GameObject TraceTwo;

    private int costTraceTwo = 20;

    public void SelectYellowCar()
    {
        CarType = 1;
        TraceOne.SetActive(true);
        TraceTwo.SetActive(true);

        if (Coins.TotalCash >= costTraceTwo)
        {
            TraceTwo.GetComponent<Button>().interactable = true;
        }
    }

    public void SelectBlueCar()
    {
        CarType = 2;
        TraceOne.SetActive(true);
        TraceTwo.SetActive(true);

        if (Coins.TotalCash >= costTraceTwo)
        {
            TraceTwo.GetComponent<Button>().interactable = true;
        }
    }
}
