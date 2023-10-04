using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomnumbers : MonoBehaviour
{
    // Start is called before the first frame update
    public int[] randomArray;
    public int minimumValue = 0;
    public int maximumValue = 26;

    void Start()
    {
        randomArray = new int[10];
        // string arrayString = "[ ";
        string elementsOverFifteen = "[ ";
        for (int i = 0; i < randomArray.Length; i++) {
            randomArray[i] = Random.Range(minimumValue, maximumValue);
            // arrayString = arrayString + randomArray[i] + " ";
            if (randomArray[i] > 15) {
                elementsOverFifteen = elementsOverFifteen + randomArray[i] + " ";
            }
        }
        // arrayString = arrayString + "]";
        elementsOverFifteen = elementsOverFifteen + "]";
        Debug.Log(elementsOverFifteen);
    }

    // Update is called once per frame
    void Update()
    {
        int randomIndex = Random.Range(0, randomArray.Length);
        randomArray[randomIndex] = Random.Range(minimumValue, maximumValue);
        string elementsOverFifteen = "[ ";
        // string arrayString = "[ ";
        for (int i = 0; i < randomArray.Length; i++) {
            // arrayString = arrayString + randomArray[i] + " ";
            if (randomArray[i] > 15) {
                elementsOverFifteen = elementsOverFifteen + randomArray[i] + " ";
            }
        }
        // arrayString = arrayString + "]";
        elementsOverFifteen = elementsOverFifteen + "]";
        Debug.Log(elementsOverFifteen);
    }
}
