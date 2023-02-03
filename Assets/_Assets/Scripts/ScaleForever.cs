using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script scales its transform up over time.
/// 
/// We will make this script to learn about variables and functions and Vector3 math.
/// 
/// Tip: To make your transform grow like a tree,
/// place this script on a parent placed where it contacts the ground.
/// </summary>

public class ScaleForever : MonoBehaviour
{
    public Vector3 setScale = new Vector3(1, 1, 1);
    public float multiplier = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        //setScale = new Vector3(1.5f, 1.5f, 1.5f);
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
        outVector = inVector + setScale * multiplier * Time.deltaTime;
        return outVector;
    }
}
