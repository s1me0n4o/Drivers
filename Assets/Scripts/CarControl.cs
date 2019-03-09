using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class CarControl : MonoBehaviour
{
    public GameObject carControl;
    public GameObject carAI;

    // Start is called before the first frame update
    void Start()
    {
        carControl.GetComponent<CarUserControl>().enabled = true;
        carAI.GetComponent<CarAIControl>().enabled = true;
        CarController.m_Topspeed = 200.0f;
    }

}
