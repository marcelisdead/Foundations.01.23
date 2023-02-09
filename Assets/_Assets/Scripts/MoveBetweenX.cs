using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script moves the local x position of transform
/// between localPosition.x and localPosition.x + distance.
/// 
/// We'll use this script as an example of C# convention and syntax.
/// 
/// Tip: Becasue this script uses localPostion, if you give this transform 
/// a parent, you can rotate the parent to change direction we wag in.
/// </summary>

public class MoveBetweenX : MonoBehaviour
{
    public float moveDistance = 3f;
    public float moveSpeed = 1f;

    Vector3 _currentDirection;
    float _xMin;
    float _xMax;

    // Start is called before the first frame update
    private void Start()
    {
        _currentDirection = Vector3.right;
        _xMin = transform.localPosition.x;
        _xMax = transform.localPosition.x + moveDistance;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = _currentDirection * moveSpeed * Time.deltaTime;
        transform.localPosition += movement;

        SetDirection( transform.localPosition.x );
    }

    void SetDirection(float currentXPosition)
    {
        if (currentXPosition > _xMax)
        {
            _currentDirection = Vector3.left;
        }
        else if (currentXPosition < _xMin)
        {
            _currentDirection = Vector3.right;
        }
        /*
        else
        {
            X is in between min and max so direction is ok for now.
            This is in a comment so the computer doesnt see it.
        }
        */
    }
}
