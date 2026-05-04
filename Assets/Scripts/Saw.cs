using UnityEngine;

public class SawTrap : MonoBehaviour
{
    public float speed = 2f;
    public float distance = 4f;

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        float move = Mathf.PingPong(Time.time * speed, distance);
        transform.position = startPos + Vector3.up * move;
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            HP hp = other.gameObject.GetComponent<HP>();

            if (hp != null)
            {
                hp.TakeDamage(1);
            }
        }
    }
}