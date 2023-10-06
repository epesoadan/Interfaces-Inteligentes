using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spheregroup : MonoBehaviour
{
    private GameObject[] spheres;
    public float[] distances;
    // Start is called before the first frame update
    void Start()
    {
        GameObject cube = GameObject.FindWithTag("cube");
        spheres = GameObject.FindGameObjectsWithTag("sphere_group2");
        distances = new float[spheres.Length];
        float smallest_distance = float.PositiveInfinity;
        int min_distance_index = 0;
        for (int i = 0; i < spheres.Length; i++) {
            distances[i] = Vector3.Distance(spheres[i].transform.position, cube.transform.position);
            if (distances[i] < smallest_distance) {
                smallest_distance = distances[i];
                min_distance_index = i;
            }
        }
        
        float new_y = spheres[min_distance_index].transform.position.y + 2;
        spheres[min_distance_index].transform.position = new Vector3(spheres[min_distance_index].transform.position.x, new_y, spheres[min_distance_index].transform.position.z);
    }

    // Update is called once per frame
    void Update()
    { 
        if (Input.GetKeyDown(KeyCode.Space)) {
            float largest_distance = float.NegativeInfinity;
            int max_distance_index = 0;
            for (int i = 0; i < spheres.Length; i++) {
                if (distances[i] > largest_distance) {
                    largest_distance = distances[i];
                    max_distance_index = i;
                }
            }
            spheres[max_distance_index].GetComponent<Renderer>().material.color = new Color(Random.Range (0f, 1f), Random.Range (0f, 1f), Random.Range (0f, 1f));
        }
    }
}
