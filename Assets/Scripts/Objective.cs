using UnityEngine;

public class Objective : MonoBehaviour
{
    public float health = 100f;

    void OnCollisionEnter (Collision col)
    {
        health -= 25;
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        FindObjectOfType<AudioManager>().Play("Game Over");
        Destroy(gameObject);
    }
}
