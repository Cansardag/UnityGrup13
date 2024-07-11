using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    //Singleton
    public static PlayerInventory Instance;
    [Header("References")]
    [SerializeField] Transform handPosition;

    [Header("Settings")]
    public int maxInventoryCount = 4;
    int currentInventoryCount = 0;

    //Private
    int currentSelectedInventorySlot = 0;
    [SerializeField] private List<EquipableItem> equipableItems = new List<EquipableItem>(4);
    GameObject spawnedItem;

    private void Awake()
    {
        if (Instance != null)
            Destroy(this.gameObject);

        Instance = this;

        for (int i = equipableItems.Count; i < 4; i++)
        {
            equipableItems.Add(null);
        }
    }

    public void AddEquipableItem(EquipableItem _item)
    {
        // Find the first empty slot (null or an empty slot)
        int emptySlotIndex = equipableItems.FindIndex(item => item == null);

        if (emptySlotIndex == -1)
        {
            // Inventory Full Message
            return;
        }

        // Assign the new item to the first empty slot
        equipableItems[emptySlotIndex] = _item;

        if (spawnedItem == null)
            SetHandItem(emptySlotIndex);

        // Set UI
    }

    private void Update()
    {
        HandleSlots();
    }

    private void HandleSlots()
    {
        if (Input.GetKeyDown(KeyCode.G) && spawnedItem != null)
        {
            DropItem();
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SetHandItem(0);
            currentSelectedInventorySlot = 0;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SetHandItem(1);
            currentSelectedInventorySlot = 1;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SetHandItem(2);
            currentSelectedInventorySlot =2;
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            SetHandItem(3);
            currentSelectedInventorySlot = 3;
        }
    }

    private void DropItem()
    {
        SetSlotNull(currentSelectedInventorySlot);
        spawnedItem.transform.parent = null;
        Rigidbody _rb = spawnedItem.GetComponent<Rigidbody>();
        _rb.isKinematic = false;
        _rb.useGravity = true;
        spawnedItem.GetComponent<Collider>().enabled = true;
        _rb.AddForce(handPosition.forward * 5, ForceMode.Impulse);
    }

    public void SetHandItem(int slotIndex)
    {
        /*if (spawnedItem != null)
            Destroy(spawnedItem);*/

        if (equipableItems[slotIndex] != null)
        {
           var _a = Instantiate(equipableItems[slotIndex].prefab, handPosition);
            _a.transform.localPosition = Vector3.zero;
            _a.transform.localRotation = Quaternion.Euler(equipableItems[slotIndex].localRotation);
            spawnedItem = _a;
            Rigidbody rb = _a.GetComponent<Rigidbody>();
            rb.isKinematic = true;
            rb.useGravity = false;
            _a.GetComponent<Collider>().enabled = false;

        }
    }

    private void SetSlotNull(int slotIndex)
    {
        equipableItems[slotIndex] = null;
    }
}
