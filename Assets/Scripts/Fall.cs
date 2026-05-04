using UnityEngine;

public class Fall : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player Fall!");
            HP hp = other.gameObject.GetComponent<HP>();

            if (hp != null)
            {
                hp.TakeDamage(3);
            }
        }
    }
}
