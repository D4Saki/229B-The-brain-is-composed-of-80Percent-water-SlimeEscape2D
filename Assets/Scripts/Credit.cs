using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsScroll : MonoBehaviour
{
    [Header("Scroll")]
    public float speed = 50f;

    [Header("Timer")]
    public float duration = 10f;

    [Header("Scene")]
    public string nextScene = "Open";

    RectTransform rect;
    float timer = 0f;

    void Start()
    {
        rect = GetComponent<RectTransform>();

        // เริ่มจากล่างจอ
        rect.anchoredPosition = new Vector2(-0, -600);
    }

    void Update()
    {
        // เลื่อนขึ้น
        rect.anchoredPosition += Vector2.up * speed * Time.deltaTime;

        // จับเวลา
        timer += Time.deltaTime;

        if (timer >= duration)
        {
            SceneManager.LoadScene(nextScene);
        }
    }
}