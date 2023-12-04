using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SocketSpawner : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject currentlyHeldPrefab;

    public void SpawnPrefab( GameObject prefabToSpawn )
    {
        if(currentlyHeldPrefab != null)
        {
            Destroy(currentlyHeldPrefab);
        } 
        Debug.Log("spawning!");
        currentlyHeldPrefab = Instantiate(prefabToSpawn, spawnPoint.position, spawnPoint.rotation);
    }

    public void ReleaseHeld()
    {
        currentlyHeldPrefab = null;
    }

    public void RegisterHold(SelectEnterEventArgs args)
    {
        currentlyHeldPrefab = args.interactableObject.transform.gameObject;
    }

}
