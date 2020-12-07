using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerActivator : MonoBehaviour
{

    public UnityEvent enterAction;
    public UnityEvent exitAction;

    private void OnTriggerEnter(Collider other)
    {
        enterAction.Invoke();
    }
    private void OnTriggerExit(Collider other)
    {
        exitAction.Invoke();
    }
}
