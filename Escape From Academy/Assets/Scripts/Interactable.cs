using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    public abstract void OnFocus();
    public abstract void OnLoseFocus();
    public abstract void OnInteract();
}
