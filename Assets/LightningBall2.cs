using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningBall2 : MonoBehaviour {

    public GameObject lightningBallPrefab;
    public Transform Ball;
    public float speed = 100f;
    public Rigidbody2D rb;
    public int damage = 10;

    // Use this for initialization
    void Start()
    {
        rb.velocity = transform.right * speed;

    }

    void Update()
    {
        if (rb.position.x > 225)
            Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Debug.Log(hitInfo.name);
        Debug.Log(hitInfo.tag);

        if (hitInfo.tag == "ProjectileWall")
        {
            Destroy(gameObject);
        }
        else if (hitInfo.tag == "Enemy")
        {
            Damage enemy = hitInfo.GetComponent<Damage>();
            enemy.TakeDamage(damage);
            Destroy(gameObject);

        }
    }
}
