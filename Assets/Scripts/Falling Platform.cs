using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    public float fallDelay = 1.5f;

    Rigidbody2D rb;
    bool isTriggered = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.bodyType = RigidbodyType2D.Kinematic;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (!isTriggered && other.gameObject.CompareTag("Player"))
        {
            isTriggered = true;
            Invoke(nameof(Drop), fallDelay);
        }
        if (other.gameObject.CompareTag("Frame"))
        {
            Destroy(gameObject);
        }
    }

    void Drop()
    {
        rb.bodyType = RigidbodyType2D.Dynamic;
    }
}
