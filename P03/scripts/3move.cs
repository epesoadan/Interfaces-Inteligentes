using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public Vector3 moveDirection;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 2f;
        transform.position = new Vector3(transform.position.x, 0, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.Normalize(moveDirection) * speed, Space.World);
    }
}
