using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestInteractable : Interactable
{
    public override void OnFocus()
    {
        Debug.Log("LOOKING AT: " + gameObject.name);
    }

    public override void OnInteract()
    {
        Debug.Log("INTERACT AT: " + gameObject.name);

    }

    public override void OnLoseFocus()
    {
        Debug.Log("LOOSE FOCUS AT: " + gameObject.name);
    }
}
