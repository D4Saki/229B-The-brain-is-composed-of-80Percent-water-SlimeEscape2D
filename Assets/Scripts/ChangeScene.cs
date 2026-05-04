using UnityEngine;
using UnityEngine.SceneManagement; // 👈 ต้องมีอันนี้

public class ChangeScene : MonoBehaviour
{
    public string sceneName;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}