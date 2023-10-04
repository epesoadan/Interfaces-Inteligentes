using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class distances : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("SCRIPT 5");
        GameObject cube = GameObject.FindWithTag("cube");
        GameObject cylinder = GameObject.FindWithTag("cylinder");

        float cube_distance = Vector3.Distance(transform.position, cube.transform.position);
        string log = "CUBE DISTANCE: " + cube_distance;
        Debug.Log(log);

        float cylinder_distance = Vector3.Distance(transform.position, cylinder.transform.position);
        log = "CYLINDER DISTANCE: " + cylinder_distance;
        Debug.Log(log);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
