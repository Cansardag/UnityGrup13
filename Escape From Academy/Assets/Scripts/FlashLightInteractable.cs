using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLightInteractable : Interactable
{
    public EquipableItem data;
    public Rigidbody rb;
    public Collider coll;

    public override void OnFocus()
    {
    }

    public override void OnInteract()
    {

        PlayerInventory.Instance.AddEquipableItem(data);
        Destroy(this.gameObject);
    }

    public override void OnLoseFocus()
    {
    }
}
