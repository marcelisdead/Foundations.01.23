using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class OculusHands : MonoBehaviour
{
    public InputActionReference gripReference, triggerReference;
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        gripReference.action.started += GripPressed;
        gripReference.action.canceled += GripCanceled;
        triggerReference.action.started += TriggerPressed;
        triggerReference.action.canceled += TriggerCanceled;
    }

    private void OnDestroy()
    {
        gripReference.action.started -= GripPressed;
        gripReference.action.canceled -= GripCanceled;
        triggerReference.action.started -= TriggerPressed;
        triggerReference.action.canceled -= TriggerCanceled;
    }

    void GripPressed(InputAction.CallbackContext junk)
    {
        Debug.Log("Grip Pressed");
        anim.SetBool("GripPressed", true);
    }

    void GripCanceled(InputAction.CallbackContext junk)
    {
        Debug.Log("Grip Canceled");
        anim.SetBool("GripPressed", false);
    }

    void TriggerPressed(InputAction.CallbackContext junk)
    {
        Debug.Log("Trigger Pressed");
        anim.SetBool("TriggerPressed", true);
    }

    void TriggerCanceled(InputAction.CallbackContext junk)
    {
        Debug.Log("Trigger Canceled");
        anim.SetBool("TriggerPressed", false);
    }
}
