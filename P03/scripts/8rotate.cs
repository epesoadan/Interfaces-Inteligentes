using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       gameObject.transform.Rotate(0, Input.GetAxis("Horizontal"), 0);
       gameObject.transform.Translate(transform.forward * speed * Time.deltaTime);

    }
}
