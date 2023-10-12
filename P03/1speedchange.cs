using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedchange : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            string log = "Up arrow: " + Input.GetAxis("Vertical") * speed;
            Debug.Log(log);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow)) {
            string log = "Down arrow: " + -(Input.GetAxis("Vertical") * speed);
            Debug.Log(log);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow)) {
            string log = "Right arrow: " + Input.GetAxis("Horizontal") * speed;
            Debug.Log(log);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            string log = "Left arrow: " + -(Input.GetAxis("Horizontal") * speed);
            Debug.Log(log);
        }
    }
}
