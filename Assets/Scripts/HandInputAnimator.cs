using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandInputAnimator : MonoBehaviour
{

    public InputActionProperty pinchAction;
    public InputActionProperty gripAction;
    float _triggerValue;
    float _gripValue;
    Animator animator;

    // suite ici...

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        _triggerValue = pinchAction.action.ReadValue<float>();
        _gripValue = gripAction.action.ReadValue<float>();
        animator.SetFloat("Trigger", _triggerValue);
        animator.SetFloat("Grip", _gripValue);
    }
}