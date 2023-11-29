using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerareproduction : MonoBehaviour
{
    private Material tvMaterial;
    public int captureCounter = 1;
    private WebCamTexture webcamTexture;
    private string savePath = "Assets/Snapshots/snapshot";

    // Start is called before the first frame update
    void Start()
    {
        tvMaterial = GetComponent<Renderer>().material;
        webcamTexture = new WebCamTexture();
        Debug.Log(webcamTexture.deviceName);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S)) {
            webcamTexture.Play();
            tvMaterial.mainTexture = webcamTexture;
            Debug.Log("Playing");
        }
        if (Input.GetKey(KeyCode.P)) {
            webcamTexture.Pause();
            Debug.Log("Stopped");
        }
        if (Input.GetKey(KeyCode.X)) {
            Texture2D snapshot = new Texture2D(webcamTexture.width, webcamTexture.height);
            snapshot.SetPixels(webcamTexture.GetPixels());
            snapshot.Apply();
            System.IO.File.WriteAllBytes(savePath + captureCounter.ToString() + ".png", snapshot.EncodeToPNG());
            captureCounter++;
            Debug.Log("Snapshot taken");
        }
    }
}