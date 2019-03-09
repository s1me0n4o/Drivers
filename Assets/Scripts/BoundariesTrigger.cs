using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundariesTrigger : MonoBehaviour
{

    private Vector3 respownPoint;
    private float respownPointZ;
    private float respownPointX;
    private float respownPointY;
    private string LeftTag = "LeftBound";
    private string RightTag = "RightBound";
    private GameObject car;
    private string ObjectTag;

    void OnTriggerEnter(Collider other)
    {
        ObjectTag = other.tag;

        respownPointZ = other.transform.position.z;
        if (this.gameObject.tag == LeftTag)
        {
           respownPointX = (this.transform.position.x / 4) + this.transform.position.x;
        }
        else if(this.gameObject.tag == RightTag)
        {
            respownPointX = (this.transform.position.x / 4) - this.transform.position.x;
        }
        respownPointY = 0;

        respownPoint = new Vector3(respownPointX, respownPointY, respownPointZ);
        print(respownPointX);
        car = GameObject.FindGameObjectWithTag(ObjectTag);
      //  car.transform.position = respownPoint;

    }

    //void FixedUpdate()
    //{
    //    car = GameObject.FindGameObjectWithTag(ObjectTag);
    //    car.transform.position = respownPoint;
    //}

}
