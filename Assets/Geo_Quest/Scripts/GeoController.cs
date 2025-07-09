using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeoController : MonoBehaviour
{
    string variableone = "Good ";
    int var1 = 3;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
        string variabletwo = "Morning";
        Debug.Log(variableone + variabletwo);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(var1);
        var1++;
    }
}
