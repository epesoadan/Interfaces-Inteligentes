using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class align : MonoBehaviour
{
    private GameObject cube;
    private GameObject cylinder;
    // Start is called before the first frame update
    void Start()
    {
        cube = GameObject.FindWithTag("cube");
        cylinder = GameObject.FindWithTag("cylinder");
    }

    // Update is called once per frame
    void Update()
    {
        float new_x_value = transform.position.x - 5;
        cube.transform.position = new Vector3(new_x_value, cube.transform.position.y, cube.transform.position.z);
        new_x_value = transform.position.x + 5;
        cylinder.transform.position = new Vector3(new_x_value, cylinder.transform.position.y, cube.transform.position.z);
    }
}
