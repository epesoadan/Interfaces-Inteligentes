using System.Collections;
using System.Collections.Generic;
using HuggingFace.API.Examples;
using UnityEngine;
using System.Text.RegularExpressions;

public class spider_commander : MonoBehaviour
{
    private GameObject[] spiders;
    private GameObject selected_spider;
    SpeechRecognitionExample speechRecognitionExample;

    // Start is called before the first frame update
    void Start()
    {
        speechRecognitionExample = GameObject.Find("SpeechRecognitionExampleUI").GetComponent<SpeechRecognitionExample>();
        spiders = GameObject.FindGameObjectsWithTag("spider");
        selected_spider = spiders[0];
        speechRecognitionExample.OnResponse += CommandSpiders;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1")) {
            selected_spider = spiders[0];
            selected_spider.GetComponent<Animation>().Play("jump");
        } else if (Input.GetKeyDown("2")) {
            selected_spider = spiders[1];
            selected_spider.GetComponent<Animation>().Play("jump");
        } else if (Input.GetKeyDown("3")) {
            selected_spider = spiders[2];
            selected_spider.GetComponent<Animation>().Play("jump");
        }
    }

    void CommandSpiders(string command) {
        bool jumpCommand = Regex.IsMatch(command, @"thank you", RegexOptions.IgnoreCase);
        bool attackCommand = Regex.IsMatch(command, @"hello", RegexOptions.IgnoreCase);
        if (jumpCommand) {
            selected_spider.GetComponent<Animation>().Play("jump");
        } else if (attackCommand) {
            selected_spider.GetComponent<Animation>().Play("attack1");
        }
    }
}
