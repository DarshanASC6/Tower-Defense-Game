using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health = 50f;
    public float damage = 10f;
    public float range = 1;
    public float moveSpeed = 500;
    public GameObject enemy;
    public Rigidbody rb;


    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, moveSpeed * Time.deltaTime);
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Die();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Defend")
        {
            Die();
        }
    }
    void Die()
    {
        Destroy(gameObject);
        Destroy(rb);
    }
}
