using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eventsphere1 : MonoBehaviour
{
    public cubenotificator notif;
    // Start is called before the first frame update
    void Start()
    {
      notif = GameObject.Find("Cube").GetComponent<cubenotificator>();
      notif.OnAnyOtherCollision += MoveTowardsCylinder;    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void MoveTowardsCylinder() {
      Vector3 direction_to_cylinder = Vector3.Normalize(GameObject.FindWithTag("cylinder").transform.position - transform.position);
      GetComponent<Rigidbody>().AddForce(direction_to_cylinder * 150);
    }
}
