using UnityEngine;

public class QuitApplication : MonoBehaviour
{
    public void QuitGame()
    {
#if UNITY_EDITOR
        
        UnityEditor.EditorApplication.isPlaying = false;
#else
            // Build edilmi� oyunu kapatmak i�in
            Application.Quit();
#endif
    }
}
