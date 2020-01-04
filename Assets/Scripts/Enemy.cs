using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health = 50f;
    public float damage = 10f;
    public float range = 1;
    public GameObject enemy;


    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
