using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string sceneName;

    public void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void EnableScene()
    {
        // Sahne etkinle�tirme i�lemleri burada yap�lacak
        Debug.Log("EnableScene method not yet implemented for " + sceneName);
    }

    public void DisableScene()
    {
        // Sahne devre d��� b�rakma i�lemleri burada yap�lacak
        Debug.Log("DisableScene method not yet implemented for " + sceneName);
    }

    public void SetVolumeWeights(float weight)
    {
        // Ses a��rl�klar�n� ayarlama i�lemleri burada yap�lacak
        Debug.Log("SetVolumeWeights method not yet implemented with weight " + weight);
    }

    public void SetCurrentVolume(float volume)
    {
        // Mevcut ses seviyesini ayarlama i�lemleri burada yap�lacak
        Debug.Log("SetCurrentVolume method not yet implemented with volume " + volume);
    }

    public float GetDestinationVolume()
    {
        // Hedef ses seviyesini alma i�lemleri burada yap�lacak
        Debug.Log("GetDestinationVolume method not yet implemented.");
        return 0f; // Varsay�lan bir de�er d�nd�r�l�yor
    }

    public string SceneName()
    {
        // Sahne ad�n� alma i�lemleri burada yap�lacak
        return sceneName; // Varsay�lan bir de�er d�nd�r�l�yor
    }

    public GameObject ControllPanel()
    {
        // Kontrol paneli i�lemleri burada yap�lacak
        Debug.Log("ControllPanel method not yet implemented.");
        return null; // Varsay�lan bir de�er d�nd�r�l�yor
    }

    public Vector3 ReferencePoint()
    {
        // Referans noktas� i�lemleri burada yap�lacak
        Debug.Log("ReferencePoint method not yet implemented.");
        return Vector3.zero; // Varsay�lan bir de�er d�nd�r�l�yor
    }

    public GameObject Screen()
    {
        // Ekran i�lemleri burada yap�lacak
        Debug.Log("Screen method not yet implemented.");
        return null; // Varsay�lan bir de�er d�nd�r�l�yor
    }
}
