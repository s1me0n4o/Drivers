using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarWheels : MonoBehaviour
{

    public WheelCollider targetWheel;

    private Vector3 wheelPos = new Vector3();
    private Quaternion wheelRotation = new Quaternion();

    void Update()
    {
        //we are getting the postion and rotation of the collieders
        targetWheel.GetWorldPose(out wheelPos, out wheelRotation);

        //and apply them to the real wheels
        transform.position = wheelPos;
        transform.rotation = wheelRotation;
    }
}
