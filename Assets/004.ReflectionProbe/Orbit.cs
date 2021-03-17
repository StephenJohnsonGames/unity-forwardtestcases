using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{

    public Transform centrePoint;
    public bool upAxis = false;
    public bool rightAxis = false;
    private Vector3 axis;
    public float radius = 2.0f;
    public float radiusSpeed = 0.5f;
    public float rotationSpeed = 80.0f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = (transform.position - centrePoint.position).normalized * radius + centrePoint.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(upAxis == true)
        {
            axis = Vector3.up;
        }

        if(rightAxis == true)
        {
            axis = Vector3.right;
        }

        transform.RotateAround(centrePoint.position, axis, rotationSpeed * Time.deltaTime);
        Vector3 desiredPosition = (transform.position - centrePoint.position).normalized * radius + centrePoint.position;
        transform.position = Vector3.MoveTowards(transform.position, desiredPosition, Time.deltaTime * radiusSpeed);
    }
}
