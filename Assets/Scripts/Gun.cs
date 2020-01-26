using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public float impactForce = 30f;
    public float fireRate = 15f;
    public bool isAuto;

    public Camera fpsCam;
    private float nextTimeToFire = 0f;


    // Update is called once per frame
    void Update()
    {
        if ((isAuto ? Input.GetButton("Fire1") : Input.GetButtonDown("Fire1")) && Time.time >= nextTimeToFire)
        {
            Shoot();
            nextTimeToFire = Time.time + 1f / fireRate;
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Enemy target = hit.transform.GetComponent<Enemy>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }

            EnemyY target2 = hit.transform.GetComponent<EnemyY>();
            if (target2 != null)
            {
                target2.TakeDamage(damage);
            }

            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * impactForce);
            }
        }
    }



}
