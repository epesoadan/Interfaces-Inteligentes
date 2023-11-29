using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class microphoneplayer : MonoBehaviour
{
    public AudioSource audiosource;
    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        audiosource.clip = Microphone.Start("", true, 10, 44100);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R)) {
            audiosource.Play();
            Debug.Log("Reproducing");
        }

        if (Input.GetKey(KeyCode.C)) {
            Microphone.End("");
            Debug.Log("Audio recording stopped");
        }
    }
}

