using UnityEngine;

[CreateAssetMenu(menuName = "Create Equipable Item", fileName = "New Item")]
public class EquipableItem : ScriptableObject
{
    public GameObject prefab;
    public Vector3 localRotation = Vector3.zero;    
}
