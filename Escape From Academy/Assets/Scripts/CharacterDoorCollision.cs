using UnityEngine;

public class CharacterDoorCollision : MonoBehaviour
{
    public float rayDistance = 1.5f; // Adjust based on the character's size and speed
    public LayerMask doorLayer;

    void Update()
    {
        CheckForDoorCollision();
    }

    void CheckForDoorCollision()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, rayDistance, doorLayer))
        {
            DoorController door = hit.collider.GetComponent<DoorController>();
            if (door != null && door.IsOpen()) // Uses the IsOpen() method to check door state
            {
                // Implement logic to prevent character from clipping into the door
                Debug.Log("Door detected ahead, preventing clipping.");
                // Example logic: Stop character movement, etc.
            }
        }
    }
}
