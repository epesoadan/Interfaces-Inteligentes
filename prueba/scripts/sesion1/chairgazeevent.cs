using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chairgazeevent : MonoBehaviour
{
    public blackboardgazed notif;
    private Vector3 initial_position;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        initial_position = transform.position;
        notif = GameObject.Find("Tableau").GetComponent<blackboardgazed>();
        notif.IsGazed += ReturnToOriginalPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ReturnToOriginalPosition() {
      transform.Translate(initial_position * speed * Time.deltaTime);
    }
}
