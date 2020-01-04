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
        Shoot();
    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(enemy.transform.position, enemy.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Objective objective = hit.transform.GetComponent<Objective>();
            if (hit.rigidbody != null)
            {
                objective.TakeDamage(damage);
            }
        }
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
