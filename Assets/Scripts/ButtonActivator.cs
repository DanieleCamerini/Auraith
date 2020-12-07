using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonActivator : MonoBehaviour
{
    public string buttonName = "Fire1";

    public UnityEvent action;
    public UnityEvent actionUp;
    
    void Update()
    {
        if (Input.GetButtonDown(buttonName))
        {
            action.Invoke();
        }
        else if (Input.GetButtonUp(buttonName))
        {
            actionUp.Invoke();
        }
    }
}
