using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class samuraibehavior : MonoBehaviour
{
    public float smoothing = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        Input.compass.enabled = true;
        Input.gyro.enabled = true;
        Input.location.Start();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Compass active: " + Input.location.status);
        Quaternion attitude = Input.gyro.attitude;

        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, -Input.compass.trueHeading, 0), Time.deltaTime * smoothing);
        //transform.Translate(transform.forward * Input.acceleration.z * Time.deltaTime);
    }
}
