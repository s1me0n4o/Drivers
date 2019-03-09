using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{
    public int CashVal;
    public static int TotalCash;
    public GameObject CashDisplay;

    void Start()
    {
        
    }

    void Update()
    {
        CashVal = TotalCash;
        CashDisplay.GetComponent<Text>().text = CashVal.ToString(); 

    }
}
