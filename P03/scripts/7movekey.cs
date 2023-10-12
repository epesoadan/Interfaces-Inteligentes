using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movekey : MonoBehaviour
{
    private GameObject cube;
    private GameObject sphere;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        cube = gameObject;
        sphere = GameObject.FindWithTag("main_sphere");
    }

    // Update is called once per frame
    void Update()
    {   
        Vector3 moveCube = new Vector3(sphere.transform.position.x, cube.transform.position.y, sphere.transform.position.z);
        cube.transform.LookAt(moveCube);

        Vector3 moveSphere = new Vector3(Input.GetAxis("HorizontalSp"), 0, Input.GetAxis("VerticalSp"));
        sphere.transform.Translate(moveSphere * speed * Time.deltaTime);   
    }
}
