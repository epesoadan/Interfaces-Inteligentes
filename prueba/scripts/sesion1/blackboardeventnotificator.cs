using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blackboarddistance : MonoBehaviour
{
    public delegate void MyEvent();
    public event MyEvent OnCloseToBlackboard;
    public float eventDistance = 6;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float currentDistance = Vector3.Distance(GameObject.FindGameObjectWithTag("blackboard").transform.position, transform.position);
        if (currentDistance < eventDistance) {
            OnCloseToBlackboard();
        }
    }
}
