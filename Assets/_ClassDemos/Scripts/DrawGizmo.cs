using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawGizmo : MonoBehaviour
{
    public Vector3 a;
    public Vector3 b;
    public Color lineCol = Color.white;
    public Color pointCol = Color.black;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = lineCol;
        Vector3 aPoint = transform.TransformPoint(a);
        Gizmos.DrawLine(aPoint, transform.TransformPoint(b));
        Gizmos.color = pointCol;
        Gizmos.DrawWireSphere(aPoint, .1f);
    }
}
