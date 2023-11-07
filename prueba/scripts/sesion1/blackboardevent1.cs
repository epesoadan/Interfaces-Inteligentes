using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blackboardevent : MonoBehaviour
{
    public blackboarddistance notif;
    public float speed = 3;
    public float minimumDistance = 0.5f;
    private bool reachedPosition = true;
    private Vector3 randomPosition;
    // Start is called before the first frame update
    void Start()
    {
        notif = GameObject.FindGameObjectWithTag("zombie").GetComponent<blackboarddistance>();
        notif.OnCloseToBlackboard += MoveRandomly;  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MoveRandomly() {
        if (reachedPosition) {
            randomPosition = new Vector3(Random.Range(-9, 9), transform.position.y, Random.Range(-9, 9));
            transform.LookAt(randomPosition);
            transform.Translate(transform.forward * speed * Time.deltaTime);
            reachedPosition = false;
        } else {
            float currentDistance = Vector3.Distance(randomPosition, transform.position);
            transform.Translate(transform.forward * speed * Time.deltaTime);
            if (currentDistance < minimumDistance) {
                reachedPosition = true;
            }
        }
    }
}
