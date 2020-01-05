using UnityEngine;

public class Objective : MonoBehaviour
{
    public float health = 100f;

    void OnCollisionEnter (Collision col)
    {
        if (col.gameObject.name == "1")
        health -= 25;
        if (health <= 0)
        {
            Die();
        }

        if (col.gameObject.name == "2")
            health -= 25;
        if (health <= 0)
        {
            Die();
        }

        if (col.gameObject.name == "3")
            health -= 25;
        if (health <= 0)
        {
            Die();
        }

        if (col.gameObject.name == "4")
            health -= 25;
        if (health <= 0)
        {
            Die();
        }
        
        if (col.gameObject.name == "5")
            health -= 25;
        if (health <= 0)
        {
            Die();
        }

        if (col.gameObject.name == "6")
            health -= 25;
        if (health <= 0)
        {
            Die();
        }

        if (col.gameObject.name == "7")
            health -= 25;
        if (health <= 0)
        {
            Die();
        }

        if (col.gameObject.name == "8")
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
