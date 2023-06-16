using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour {

    public int health;
    

    void Start()
    {
        health = health + (SpawnerScript.wave * 5);
    }


    public void TakeDamage (int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        SpawnerScript.enemiesKilled++;
        Destroy(gameObject);
    }
}
