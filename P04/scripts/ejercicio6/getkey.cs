using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getkey : MonoBehaviour
{
    private bool has_key = false;
    public delegate void MyEvent();
    public event MyEvent OnDoorUnlock;
    public event MyEvent OnKeyGet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "key") {
            has_key = true;
            Destroy(collision.gameObject);
            OnKeyGet();
        }
        if (collision.gameObject.tag == "door" && has_key) {
            has_key = false;
            GameObject[] doors = GameObject.FindGameObjectsWithTag("door");
            foreach(GameObject door in doors) {
                Destroy(door);
            }
            OnDoorUnlock();
        }
    }
}
