using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningBall1 : MonoBehaviour {

    public Transform Ball;
    public float speed = 100f;
    public Rigidbody2D rb;
    public int damage = 10;
    private GameObject LBAvoid;
    public int stuntime;

    // Use this for initialization
    void Start()
    {
        rb.velocity = transform.right * speed;
        LBAvoid = GameObject.Find("LightningBall(Clone)").GetComponent<LightningBallScript>().ECollide;
        damage = StoreValue.LBDamage;
        stuntime = StoreValue.LBStun;
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
        else if (hitInfo.tag == "Enemy" && LBAvoid != hitInfo.gameObject)
        {
            Damage enemy = hitInfo.GetComponent<Damage>();
            enemy.TakeDamage(damage);
            SkeletonMovementScript enemy2 = hitInfo.GetComponent<SkeletonMovementScript>();
            enemy2.Stun(stuntime);
            Destroy(gameObject);

        }
    }
}
