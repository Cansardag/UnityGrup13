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
        // Sahne etkinleþtirme iþlemleri burada yapýlacak
        Debug.Log("EnableScene method not yet implemented for " + sceneName);
    }

    public void DisableScene()
    {
        // Sahne devre dýþý býrakma iþlemleri burada yapýlacak
        Debug.Log("DisableScene method not yet implemented for " + sceneName);
    }

    public void SetVolumeWeights(float weight)
    {
        // Ses aðýrlýklarýný ayarlama iþlemleri burada yapýlacak
        Debug.Log("SetVolumeWeights method not yet implemented with weight " + weight);
    }

    public void SetCurrentVolume(float volume)
    {
        // Mevcut ses seviyesini ayarlama iþlemleri burada yapýlacak
        Debug.Log("SetCurrentVolume method not yet implemented with volume " + volume);
    }

    public float GetDestinationVolume()
    {
        // Hedef ses seviyesini alma iþlemleri burada yapýlacak
        Debug.Log("GetDestinationVolume method not yet implemented.");
        return 0f; // Varsayýlan bir deðer döndürülüyor
    }

    public string SceneName()
    {
        // Sahne adýný alma iþlemleri burada yapýlacak
        return sceneName; // Varsayýlan bir deðer döndürülüyor
    }

    public GameObject ControllPanel()
    {
        // Kontrol paneli iþlemleri burada yapýlacak
        Debug.Log("ControllPanel method not yet implemented.");
        return null; // Varsayýlan bir deðer döndürülüyor
    }

    public Vector3 ReferencePoint()
    {
        // Referans noktasý iþlemleri burada yapýlacak
        Debug.Log("ReferencePoint method not yet implemented.");
        return Vector3.zero; // Varsayýlan bir deðer döndürülüyor
    }

    public GameObject Screen()
    {
        // Ekran iþlemleri burada yapýlacak
        Debug.Log("Screen method not yet implemented.");
        return null; // Varsayýlan bir deðer döndürülüyor
    }
}
