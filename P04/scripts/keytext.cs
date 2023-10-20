using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keytext : MonoBehaviour
{
    private getkey notif;
    private Text key_text;

    void Start()
    {
        notif = GameObject.Find("Sphere").GetComponent<getkey>();
        key_text = GetComponent<Text>();
        notif.OnKeyGet += GetKeyText;
        notif.OnDoorUnlock += LoseKeyText;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GetKeyText() 
    {
        key_text.text = "Key: 1"; 
    }

    void LoseKeyText()
    {
        key_text.text = ""; 
    }
}
