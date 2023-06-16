using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceSlideScript : MonoBehaviour {

    public float speed = 40f;
    public Rigidbody2D rb;
    public BoxCollider2D bc;
    public int damage = 20;

    // Use this for initialization
    void Start()
    {
        damage = StoreValue.IWDamage;
        rb.velocity = transform.right * speed;
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
        }
    }
}
