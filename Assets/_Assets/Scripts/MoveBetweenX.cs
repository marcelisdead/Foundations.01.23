using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script moves the local x position of transform
/// between localPosition.x and localPosition.x + distance.
/// 
/// We'll use this script as an example of C# convention and syntax.
/// 
/// Tip: Becasue this script uses localPostion, if you give this transform a parent,
/// you can rotate the parent to change direction we wag in.
/// </summary>

public class MoveBetweenX : MonoBehaviour
{
    public float distance = 3f;
    public float speed = 1f;

    Vector3 direction;
    float xMin;
    float xMax;

    private void Start()
    {
        direction = Vector3.right;
        xMin = transform.localPosition.x;
        xMax = transform.localPosition.x + distance;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition += direction * speed * Time.deltaTime;

        if (transform.localPosition.x > xMax)
        {
            direction = Vector3.left;
        }
        else if (transform.localPosition.x < xMin)
        {
            direction = Vector3.right;
        }
        else
        {
            //x is in between max and min
            //so direction is ok for now
        }
    }
}
