using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectname : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string object_name = "This object is a " + gameObject.name;
        Debug.Log(object_name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
