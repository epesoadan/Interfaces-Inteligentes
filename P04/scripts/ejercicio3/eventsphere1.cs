using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eventsphere1 : MonoBehaviour
{
    public cubenotificator notif;
    private bool isJumping = false;
    // Start is called before the first frame update
    void Start()
    {
      notif = GameObject.Find("Cube").GetComponent<cubenotificator>();
      notif.OnGettingCloserToCylinder += ChangeColorAndJump;    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void ChangeColorAndJump() {
      GetComponent<Renderer>().material.color = new Color(Random.Range (0f, 1f), Random.Range (0f, 1f), Random.Range (0f, 1f));
      Vector3 jump_direction = new Vector3(0f,5f,0f);
      if (!isJumping) {
        GetComponent<Rigidbody>().AddForce(jump_direction, ForceMode.Impulse);
        isJumping = true;
      }
    }
 
  void OnCollisionEnter(Collision collision) {
      if (collision.gameObject.tag == "plane") {
        isJumping = false;
      }
    }

}
