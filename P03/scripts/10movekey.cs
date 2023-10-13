using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movekey : MonoBehaviour
{
    private Rigidbody cube;
    private Rigidbody sphere;
    private Vector3 moveCube;
    private Vector3 moveSphere;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        cube = this.GetComponent<Rigidbody>();
        sphere = GameObject.FindWithTag("main_sphere").GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {   
       // Cube is kinematic, so we still use transform
       Vector3 moveCube = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
       cube.transform.Translate(moveCube * (speed/2) * Time.deltaTime);

       moveSphere = new Vector3(Input.GetAxis("HorizontalSp"), 0, Input.GetAxis("VerticalSp"));
       //sphere.transform.Translate(moveSphere * speed * Time.deltaTime);
    }

    void FixedUpdate()
    {
        //cube.AddForce(moveCube * speed * Time.fixedDeltaTime);
        sphere.AddForce(moveSphere * (speed * 2) * Time.fixedDeltaTime);
    }
}
