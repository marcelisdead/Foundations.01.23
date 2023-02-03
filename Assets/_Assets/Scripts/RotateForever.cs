using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine;
/// <summary> We found the elements of the code on line 17 while learning about the template script and the Unity Docs </summary>
public class RotateForever : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up);
    }
}


