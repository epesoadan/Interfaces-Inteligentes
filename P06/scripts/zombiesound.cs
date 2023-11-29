using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombiesound: MonoBehaviour
{
    public AudioClip zombieEatClip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "spider") {
            AudioSource audio = GetComponent<AudioSource>();
            audio.clip = zombieEatClip;
            audio.Play();
        }
    }
}
