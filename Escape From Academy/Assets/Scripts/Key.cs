using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject keyModel; // Anahtar modelini referans olarak alýr.
    public Transform handTransform; // Karakterin elinin pozisyonunu referans olarak alýr.
    public KeyCode pickUpKey = KeyCode.E; // Anahtarý almak için kullanýlacak tuþ.
    private bool isPickedUp = false; // Anahtarýn alýnýp alýnmadýðýný kontrol eder.

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
