using UnityEngine;

public class QuitApplication : MonoBehaviour
{
    public void QuitGame()
    {
#if UNITY_EDITOR
        
        UnityEditor.EditorApplication.isPlaying = false;
#else
            // Build edilmiþ oyunu kapatmak için
            Application.Quit();
#endif
    }
}
