using UnityEngine;

public class HP : MonoBehaviour
{
    public int maxHealth = 3;
    int currentHealth;
    public HeartUI HeartUI;
    public Transform respawnPoint;

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
            Respawn();
        }
    }

    void Respawn()
    {
        transform.position = respawnPoint.position;
        
        currentHealth = maxHealth;
        HeartUI.UpdateHearts(currentHealth);

        Debug.Log("Respawn!");
    }
}