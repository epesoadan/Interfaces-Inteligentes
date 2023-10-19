using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class writepoints : MonoBehaviour
{
    private getpoints notif;
    private Text point_text;

    void Start()
    {
        notif = GameObject.Find("Cube").GetComponent<getpoints>();
        point_text = GetComponent<Text>();
        point_text.text =  "Points: 0";
        notif.OnSphereGet += UpdatePoints;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdatePoints() 
    {
        Debug.Log("ok");
       point_text.text = "Points: " + notif.current_points; 
    }
}
