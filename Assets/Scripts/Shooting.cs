using UnityEngine;

public class Shooter : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] private Transform shootPoint;
    [SerializeField] private Transform player;

    [Header("Prefab")]
    [SerializeField] private Rigidbody2D bulletPrefab;

    [Header("ยิง")]
    [SerializeField] private float fireRate = 2f;
    [SerializeField] private float timeToTarget = 1f;

    float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= fireRate)
        {
            ShootAtPlayer();
            timer = 0f;
        }
    }

    void ShootAtPlayer()
    {
        Vector2 origin = shootPoint.position;
        Vector2 targetPos = player.position;

        // คำนวณความเร็ว projectile
        Vector2 velocity = CalculateProjectileVelocity(origin, targetPos, timeToTarget);

        Rigidbody2D bullet = Instantiate(
            bulletPrefab,
            shootPoint.position,
            Quaternion.identity
        );

        bullet.linearVelocity = velocity;
    }

    Vector2 CalculateProjectileVelocity(Vector2 origin, Vector2 target, float time)
    {
        Vector2 direction = target - origin;

        float g = Mathf.Abs(Physics2D.gravity.y);

        float vx = direction.x / time;
        float vy = (direction.y / time) + (0.5f * g * time);

        return new Vector2(vx, vy);
    }
}