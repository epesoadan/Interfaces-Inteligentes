using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T)) {
            Vector3 randomPosition = new Vector3(Random.Range(-9, 9), transform.position.y, Random.Range(-9, 9));
            transform.position = randomPosition;
        }
    }
}
