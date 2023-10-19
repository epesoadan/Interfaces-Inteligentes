using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eventsphere2 : MonoBehaviour
{
    public cubenotificator notif;
    // Start is called before the first frame update
    void Start()
    {
      notif = GameObject.Find("Cube").GetComponent<cubenotificator>();
      notif.OnCollisionWithSphere1 += GetBigger;    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void GetBigger() {
      GetComponent<Transform>().localScale += new Vector3(0.3f, 0.3f, 0.3f);
    }
}
