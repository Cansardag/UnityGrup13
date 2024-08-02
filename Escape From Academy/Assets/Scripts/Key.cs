using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject keyModel; // Anahtar modelini referans olarak al�r.
    public Transform handTransform; // Karakterin elinin pozisyonunu referans olarak al�r.
    public KeyCode pickUpKey = KeyCode.E; // Anahtar� almak i�in kullan�lacak tu�.
    private bool isPickedUp = false; // Anahtar�n al�n�p al�nmad���n� kontrol eder.

    void Update()
    {
        if (Input.GetKeyDown(pickUpKey))
        {
            if (!isPickedUp)
            {
                PickUp();
            }
        }
    }

    void PickUp()
    {
        keyModel.transform.SetParent(handTransform);
        keyModel.transform.localPosition = Vector3.zero;
        keyModel.transform.localRotation = Quaternion.identity;
        isPickedUp = true;
    }
}
