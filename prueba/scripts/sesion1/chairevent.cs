using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chairevent : MonoBehaviour
{
    public zombienotificator notif;
    private GameObject zombie;
    private GameObject[] spiders;
    public int speed;

    // Start is called before the first frame update
    void Start()
    {
        zombie = GameObject.Find("Zombie");
        spiders = GameObject.FindGameObjectsWithTag("spider");

        notif = zombie.GetComponent<zombienotificator>();
        notif.OnChairCollision += MoveSpidersTowardsZombie;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MoveSpidersTowardsZombie() {
      for (int i = 0; i < spiders.Length; i++) {
        Vector3 new_position = zombie.transform.position;
        spiders[i].GetComponent<Rigidbody>().MovePosition(new_position);
      }
    }
}
