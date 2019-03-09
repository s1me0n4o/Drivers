using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Path : MonoBehaviour
{

    public Color lineColor;
    private List<Transform> points = new List<Transform>();
    public float sphereRadius = 0.3f;

    //OnDrawGizmos is like Update but it executes when scene view updates
    //OnDrawGizmosSelected executes only when the object is selected
    void OnDrawGizmosSelected()
    {
        //setting the Gizmos our line color
        Gizmos.color = lineColor;
         
    //in order to get the points and draw a line between them we are creating an array that will cointain all Transforms
        //Creating array to store the Chield objects(in our case that are the Points)
        Transform[] pathTransforms = GetComponentsInChildren<Transform>();

     //we should fiter the transforms, because we need the transforms of the Points only(we have all transforms now).
        //we are creating a new list to make sure its empty
        points = new List<Transform>();

        for (int i = 0; i < pathTransforms.Length; i++)
        {
            //if the transform is not our own transfrom -> add it to the list
            if (pathTransforms[i] != transform)
            {
                points.Add(pathTransforms[i]);
            }
        }

        //drawing the lines between the points
        for (int i = 0; i < points.Count; i++)
        {
            Vector3 currentPoint = points[i].position;
            Vector3 previousPoints = Vector3.zero;

            if (i > 0)
            {
                previousPoints = points[i - 1].position;
            }
            else if (i == 0 && points.Count > 1)
            {
                //if we are on the first point and there are more than 2 points we are getting the last point
                previousPoints = points[points.Count - 1].position;
            }

            Gizmos.DrawLine(previousPoints, currentPoint);
            Gizmos.DrawWireSphere(currentPoint, sphereRadius);
        }
    }
}
