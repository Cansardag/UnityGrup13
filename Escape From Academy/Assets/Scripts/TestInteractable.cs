using UnityEngine;

public class TestInteractable : Interactable
{
    public override void OnFocus()
    {
        Debug.Log("Object focused.");
    }

    public override void OnLoseFocus()
    {
        Debug.Log("Object lost focus.");
    }

    public override void OnInteract()
    {
        Debug.Log("Object interacted with.");
    }
}
