using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public GameObject flashlightModel; // El fenerinin modelini referans olarak alýr.
    public Transform handTransform; // Karakterin elinin pozisyonunu referans olarak alýr.
    public KeyCode pickUpKey = KeyCode.E; // El fenerini almak için kullanýlacak tuþ.
    private bool isPickedUp = false; // El fenerinin alýnýp alýnmadýðýný kontrol eder.
    private Light flashlightLight; // El fenerinin ýþýðýný kontrol eder.

    // El fenerinin el pozisyonuna göre offset ayarlarý
    public Vector3 positionOffset;
    public Vector3 rotationOffset;

    void Start()
    {
        flashlightLight = flashlightModel.GetComponentInChildren<Light>();
        if (flashlightLight != null)
        {
            flashlightLight.enabled = false; // Baþlangýçta ýþýk kapalý.
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
        flashlightModel.transform.localRotation = Quaternion.Euler(rotationOffset); // Fenerin düz durmasýný saðlayacak rotasyonu belirleyin.
    }
}
