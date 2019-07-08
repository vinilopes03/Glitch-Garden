using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float health = 100f;
    [SerializeField] GameObject particlesExplosion;

    // Start is called before the first frame update
    // Update is called once per frame
    public void DealDamage(float damage)
    {
        health -= damage;
        if(health <= 0)
        {
            ExplosionVFX();
            Destroy(gameObject);
        }
    }

    public float getHealth()
    {
        return health;
    }

    private void ExplosionVFX()
    {
        if (!particlesExplosion) { return; }

        GameObject deathVFX = Instantiate(particlesExplosion, transform.position, Quaternion.identity);
        Destroy(deathVFX, 1f);
    }
}
