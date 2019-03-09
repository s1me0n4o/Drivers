using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
    
    public class FinishTrigger : MonoBehaviour
{
    public GameObject car;
    public GameObject finishCam;
    public GameObject viewModes;

    void OnTriggerEnter()
    {
        this.GetComponent<BoxCollider>().enabled = false;
        car.SetActive(false);
        CarController.m_Topspeed = 0.0f;
        car.GetComponent<CarController>().enabled = false;
        car.GetComponent<CarUserControl>().enabled = false;
        car.SetActive(true);
        finishCam.SetActive(true);
        viewModes.SetActive(true);
        gameObject.GetComponent<CarAudio>().enabled = false;
    }
}
