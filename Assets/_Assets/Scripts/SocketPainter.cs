using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SocketPainter : MonoBehaviour
{
    public GameObject socketedOject;
    public void RegisterObject(SelectEnterEventArgs args)
    {
        socketedOject = args.interactableObject.transform.gameObject;
    }

    public void ReleaseObject()
    {
        socketedOject = null;
    }

    public void ChangeMaterial(Material newMaterial)
    {
        if(socketedOject != null)
        {
            Renderer[] renderers = socketedOject.GetComponentsInChildren<Renderer>();
            foreach(Renderer rend in renderers)
            {
                rend.material = newMaterial;
            }
        }
    }
}
