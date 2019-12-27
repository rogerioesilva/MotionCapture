using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float RotationalSpeed = 5f;
    public Transform referencePoint;
    public float FOV = 60.0f;

    // Update is called once per frame
    void Update()
    {
        float axis = 0f;
        if (Input.GetKey("left"))
            axis = -1f;
        if (Input.GetKey("right"))
            axis = 1f;
        if (Input.GetKey("up"))
            FOV -= 1f;
        if (Input.GetKey("down"))
            FOV += 1f;

        transform.RotateAround(referencePoint.position, Vector3.up, -axis * RotationalSpeed * Time.deltaTime);
        Camera.main.fieldOfView = FOV;
    }
}
