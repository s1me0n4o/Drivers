using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTimeManager : MonoBehaviour
{
    public static int mins;
    public static int secs;
    public static float mil;
    public static string milDisplay;

    public GameObject Minutes;
    public GameObject Seconds;
    public GameObject MilliSecs;

    // Update is called once per frame
    void Update()
    {
        mil += Time.deltaTime * 10;
        milDisplay = mil.ToString("F0");
        MilliSecs.GetComponent<Text>().text= "" + milDisplay;

        if (mil >= 10)
        {
            mil = 0;
            secs++;
        }

        if (secs <= 9)
        {
            Seconds.GetComponent<Text>().text = "0" + secs + ".";
        }
        else
        {
            Seconds.GetComponent<Text>().text = "" + secs + ".";
        }

        if (secs >= 60)
        {
            secs = 0;
            mins++;
        }

        if (mins <= 9)
        {
            Minutes.GetComponent<Text>().text = "0" + mins + ":";
        }
        else
        {
            Minutes.GetComponent<Text>().text = "" + mins + ":";
        }
    }
}
