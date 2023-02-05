using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    //notice what they initialize to
    //color is black , rend is null

    //struct is value type variable
    public Color colorA;
    //class is reference type variable
    public MeshRenderer rendA;

    Color colorB;
    MeshRenderer rendB;

    void Start()
    {
        // just to show changing the color in code
        rendA.material.color = colorA;

        /*
        // A = blue
        colorA = Color.blue;
        rendA.material.color = Color.blue;

        // B = A
        colorB = colorA;
        rendB  = rendA;

        // B = red
        colorB = Color.red;
        rendB.material.color = Color.red;
        */

        // Run the game to see if
        // rendA's color = colorA ?


        //because its cool
        //rendA.material.color = Random.ColorHSV();
    }
}
