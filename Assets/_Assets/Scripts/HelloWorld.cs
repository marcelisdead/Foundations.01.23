using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    int frameCount;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello, World!");
        frameCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        frameCount = frameCount + 1;
        string coolMessage = "Frame Count: " + frameCount;
        Debug.LogError(coolMessage);
    }
}
