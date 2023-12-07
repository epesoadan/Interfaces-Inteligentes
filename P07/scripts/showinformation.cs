using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showinformation : MonoBehaviour
{
    private Text information_text;

    void Start()
    {
        Input.gyro.enabled = true;
        information_text = GetComponent<Text>();
        Input.location.Start();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Active: " + Input.location.status);
        information_text.text =  "Velocidad angular: " + Input.gyro.rotationRate + "\n" +
        "Aceleracion: " + Input.acceleration + "\n" +
        "Altitud: " + Input.location.lastData.altitude + "\n" +
        "Gravedad: " + Input.gyro.gravity + "\n" +
        "Longitud: " + Input.location.lastData.longitude + "\n" +
        "Latitud: " + Input.location.lastData.latitude + "\n";
    }
}
