using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventOnTrigger : MonoBehaviour
{
    public UnityEvent OnEnter;

    public bool doCheckTag;
    public string tagToCheck;

    private void OnTriggerEnter(Collider other)
    {
        if (doCheckTag)
        {
            if (other.CompareTag(tagToCheck))
            {
                OnEnter.Invoke();
                Debug.Log(other.name);
            }
        }
        else
        {
            OnEnter.Invoke();
            Debug.Log(other.name);
        }

    }
}
