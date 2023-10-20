using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movesphere : MonoBehaviour
{
    private Vector3 moveSphere;
    public int speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveSphere = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    }

    void FixedUpdate()
    {
        GetComponent<Rigidbody>().MovePosition(transform.position + moveSphere * (speed * 2) * Time.fixedDeltaTime);
    }
}
