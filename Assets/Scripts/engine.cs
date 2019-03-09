using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class engine : MonoBehaviour
{

    public Transform path;
    private List<Transform> points;
    private int currentPoint = 0;
    public float maxSteerAngle = 45;
    public WheelCollider wheelFrontLeft;
    public WheelCollider wheelFrontRight;
    public float forwardForce = 1000f;
    public float maxSpeed = 1300f;
    private float currentSpeed;

    public Vector3 centerOfMass;

    public bool isBreaking = false;
    public float maxBrakeTorque = 400f;

    // Start is called before the first frame update
    void Start()
    {
        //we are creating this var in order to change the change the mass in the buttom of the car for more stable
        GetComponent<Rigidbody>().centerOfMass = centerOfMass;

        // we need all points.
        //since the script is attached to the car (and we are about to link the path to the car) -> we need the points attached to the path
        Transform[] pathTransforms = path.GetComponentsInChildren<Transform>();

        points = new List<Transform>();

        for (int i = 0; i < pathTransforms.Length; i++)
        {
            //if the transform is not our own transfrom -> add it to the list
            if (pathTransforms[i] != path.transform)
            {
                points.Add(pathTransforms[i]);
                print(pathTransforms[i]);
            }
        }
    } 

        private void FixedUpdate()
        {
            ApplySteer();
            ForwardForce();
            CheckWaypoint();
            Braking();
        }


        private void ApplySteer()
        {

        Vector3 relativeVector = transform.InverseTransformPoint(points[currentPoint].position);
        //we need a value between 1 and -1 in order to know if we are going to turn left(-1) or right(1). So we need to devide the vector value of X to its lenght
            float cornerAngle = (relativeVector.x / relativeVector.magnitude) * maxSteerAngle;
        //apply the angle to the wheelColliders
            wheelFrontLeft.steerAngle = cornerAngle;
            wheelFrontRight.steerAngle = cornerAngle;
        }

        private void ForwardForce()
        {
        //.motorTorque is the engine of our car

            currentSpeed = 2 * Mathf.PI * wheelFrontLeft.radius * wheelFrontLeft.rpm * 60 / 1000;

            if (currentSpeed < maxSpeed)
            {
                wheelFrontLeft.motorTorque = forwardForce;
                wheelFrontRight.motorTorque = forwardForce;
            } else
            {
                wheelFrontLeft.motorTorque = maxSpeed - 100f;
                wheelFrontRight.motorTorque = maxSpeed - 100f;
            }

        }
    
        private void CheckWaypoint()
        {
            if (Vector3.Distance(transform.position, points[currentPoint].position) < 5f)
	        {
                if (currentPoint == points.Count - 1)
                {
                    currentPoint = 0;
                }
                else
                {
                    currentPoint++;
                }
	        }
        }

        private void Braking()
    {

    }
}       
