using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getpoints : MonoBehaviour
{
    public int current_points = 0;
    public delegate void MyEvent();
    public event MyEvent OnSphereGet;

    // Start is called before the first frame update
    void Start()
    {   
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "sphere_group1" || collision.gameObject.tag == "sphere_group2") {
            if (collision.gameObject.tag == "sphere_group2") {
                current_points += 5;
            } else {
                current_points += 10;
            }
            Destroy(collision.gameObject);
            Debug.Log(current_points);
            OnSphereGet();
        }
    }
}
