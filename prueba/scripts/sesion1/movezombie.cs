using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movezombie : MonoBehaviour
{
    public float speed = 3;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(0, Input.GetAxis("Horizontal"), 0);
        gameObject.transform.Translate(transform.forward * speed * Time.deltaTime);
        //transform.position += Vector3.forward * speed * Time.deltaTime;
    }
}
