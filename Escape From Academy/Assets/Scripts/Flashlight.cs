using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public GameObject flashlightModel; // El fenerinin modelini referans olarak al�r.
    public Transform handTransform; // Karakterin elinin pozisyonunu referans olarak al�r.
    public KeyCode pickUpKey = KeyCode.E; // El fenerini almak i�in kullan�lacak tu�.
    private bool isPickedUp = false; // El fenerinin al�n�p al�nmad���n� kontrol eder.
    private Light flashlightLight; // El fenerinin �����n� kontrol eder.

    // El fenerinin el pozisyonuna g�re offset ayarlar�
    public Vector3 positionOffset;
    public Vector3 rotationOffset;

    void Start()
    {
        flashlightLight = flashlightModel.GetComponentInChildren<Light>();
        if (flashlightLight != null)
        {
            flashlightLight.enabled = false; // Ba�lang��ta ���k kapal�.
        }
        else
        {
            Debug.LogError("Flashlight light not found in the model.");
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(pickUpKey))
        {
            if (!isPickedUp)
            {
                PickUp();
            }
            else
            {
                ToggleLight();
            }
        }
        if (isPickedUp)
        {
            UpdateFlashlightPosition();
        }
    }

    void PickUp()
    {
        flashlightModel.transform.SetParent(handTransform);
        flashlightModel.transform.localPosition = positionOffset;
        flashlightModel.transform.localRotation = Quaternion.Euler(rotationOffset);
        isPickedUp = true;
    }

    void ToggleLight()
    {
        if (flashlightLight != null)
        {
            flashlightLight.enabled = !flashlightLight.enabled;
        }
    }

    void UpdateFlashlightPosition()
    {
        flashlightModel.transform.localPosition = positionOffset;
        flashlightModel.transform.localRotation = Quaternion.Euler(rotationOffset); // Fenerin d�z durmas�n� sa�layacak rotasyonu belirleyin.
    }
}
