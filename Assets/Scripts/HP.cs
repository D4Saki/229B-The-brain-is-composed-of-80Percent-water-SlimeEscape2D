using UnityEngine;

public class HP : MonoBehaviour
{
    public int maxHealth = 3;
    int currentHealth;
    public HeartUI HeartUI;

    void Start()
    {
        currentHealth = maxHealth;
        HeartUI.UpdateHearts(currentHealth);
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        Debug.Log("HP: " + currentHealth);
        HeartUI.UpdateHearts(currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Player Dead");
        Destroy(gameObject);
    }
}