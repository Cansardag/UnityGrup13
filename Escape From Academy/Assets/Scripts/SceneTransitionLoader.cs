using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionLoader : MonoBehaviour
{
    public string sceneName;

    public void LoadScene()
    {
        if (!string.IsNullOrEmpty(sceneName))
        {
            Debug.Log("Loading scene: " + sceneName); // Debug log ekleyerek sahnenin yüklendiðini kontrol edin
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            Debug.LogWarning("Scene name is empty or null");
        }
    }

    public void LoadSceneByName(string sceneToLoad)
    {
        Debug.Log("Loading scene: " + sceneToLoad); // Debug log ekleyerek sahnenin yüklendiðini kontrol edin
        SceneManager.LoadScene(sceneToLoad);
    }
}
