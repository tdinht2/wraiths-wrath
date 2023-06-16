using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballScript : MonoBehaviour {
    public float speed = 100f;
    public Rigidbody2D rb;
    public CircleCollider2D cd;
    public int damage = 20;

	// Use this for initialization
	void Start () {
        speed = StoreValue.FBSpeed;
        rb.velocity = transform.right * speed;
        damage = StoreValue.FBDamage;
    }

    void Update()
    {
        if (rb.position.x > 225)
            Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.tag == "ProjectileWall")
        {
            Destroy(gameObject);
        }
        else if (hitInfo.tag == "Enemy")
        {
            Damage enemy = hitInfo.GetComponent<Damage>();
            enemy.TakeDamage(damage);
            if (StoreValue.FBPass != true)
            {
                Destroy(gameObject);
            }

        }
    }
    
	
}
