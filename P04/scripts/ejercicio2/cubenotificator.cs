using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubenotificator : MonoBehaviour
{
    public delegate void MyEvent();
    public event MyEvent OnAnyOtherCollision;
    public event MyEvent OnCollisionWithSphere1;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "sphere_group1") {
            if (OnCollisionWithSphere1 != null) {
                OnCollisionWithSphere1();
            }
        } else if (collision.gameObject.tag != "plane" && collision.gameObject.tag != "sphere_group1") {  
            if (OnAnyOtherCollision != null) {
                OnAnyOtherCollision();
            }
        }
    }
}
