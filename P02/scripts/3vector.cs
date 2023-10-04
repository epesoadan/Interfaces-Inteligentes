using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vector : MonoBehaviour
{
    
    public Vector3 vector1;
    public Vector3 vector2;

    public float vector1_magnitude;
    public float vector2_magnitude;
    public float angle;
    public float distance;
    public string higher_vector;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("SCRIPT 3");
        vector1_magnitude = vector1.magnitude;
        string log = "VECTOR 1 MAGNITUDE: " + vector1_magnitude;
        Debug.Log(log);
        vector2_magnitude = vector1.magnitude;
        log = "VECTOR 2 MAGNITUDE: " + vector2_magnitude;
        Debug.Log(log);
        angle = Vector3.Angle(vector1, vector2);
        log = "ANGLE: " + angle;
        Debug.Log(log);
        distance = Vector3.Distance(vector1, vector2);
        log = "DISTANCE: " + distance;
        Debug.Log(log);
        higher_vector = vector1.y > vector2.y ? "vector1" : "vector2";
        log = "HIGHER VECTOR: " + higher_vector;
        Debug.Log(log);
    }
}
