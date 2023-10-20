using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class notificationtext : MonoBehaviour
{
    private getkey notif;
    private Text notification_text;

    void Start()
    {
        notif = GameObject.Find("Sphere").GetComponent<getkey>();
        notification_text = GetComponent<Text>();
        notif.OnKeyGet += GetKeyText;
        notif.OnDoorUnlock += EscapeText;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GetKeyText() 
    {
        notification_text.text = "You've obtained a key!";
        Invoke("BlankText", 2);
    }

    void BlankText()
    {
        notification_text.text = "";
    }

    void EscapeText()
    {
        notification_text.text = "You've escaped!"; 
    }
}
