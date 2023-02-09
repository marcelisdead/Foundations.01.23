using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script scales its transform up over time.
/// 
/// We will make this script to learn about variables and functions
/// and Vector3 math.
/// 
/// Tip: To make your object grow like a tree,
/// place this script on a parent positioned where your object 
/// contacts the ground.
/// </summary>

public class ScaleForever : MonoBehaviour
{
    public Vector3 setScale = new Vector3(1.0f, 1.0f, 1.0f);
    // Start is called before the first frame update
    void Start()
    {
        //transform.localScale = transform.localScale + setScale;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = ScaleVector(transform.localScale);
    }


    Vector3 ScaleVector(Vector3 inVector)
    {
        Vector3 outVector;
        outVector = inVector + setScale * Time.deltaTime;
        return outVector;
    }
}
