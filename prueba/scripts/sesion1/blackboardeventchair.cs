using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blackboardeventchair : MonoBehaviour
{
    private GameObject zombie;
    public blackboarddistance notif;
    public float movingDistance = 1f;
    public float minimumDistance = 3;
    private bool reachedPosition = true;
    public float speed = 1;
    private Vector3 newPosition;
    // Start is called before the first frame update
    void Start()
    {
        zombie = GameObject.FindGameObjectWithTag("zombie");
        notif = zombie.GetComponent<blackboarddistance>();
        notif.OnCloseToBlackboard += MoveTowardsZombie;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MoveTowardsZombie() {
        if (reachedPosition) {
            transform.LookAt(zombie.transform);
            newPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z + movingDistance);
            transform.Translate(newPosition * speed * Time.deltaTime);
            reachedPosition = false;
        } else {
            float currentDistance = Vector3.Distance(newPosition, transform.position);
            transform.Translate(newPosition * speed * Time.deltaTime);
            if (currentDistance < minimumDistance) {
                reachedPosition = true;
            }
        }
    }
}
