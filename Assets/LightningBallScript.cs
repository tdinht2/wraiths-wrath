using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningBallScript : MonoBehaviour {
    
    public GameObject lightningBallPrefab;
    public Transform Ball;
    public float speed = 100f;
    public Rigidbody2D rb;
    public int damage = 10;
    public GameObject ECollide;
    public int stuntime;

    // Use this for initialization
    void Start()
    {
        rb.velocity = transform.right * speed;
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
        else if (hitInfo.tag == "Enemy")
        {
            Damage enemy = hitInfo.GetComponent<Damage>();
            enemy.TakeDamage(damage);
            SkeletonMovementScript enemy2 = hitInfo.GetComponent<SkeletonMovementScript>();
            enemy2.Stun(stuntime);
            ECollide = hitInfo.gameObject;

            if(StoreValue.LBChain >= 1)
            {
                Instantiate(lightningBallPrefab, Ball.position, Quaternion.AngleAxis(90, Vector3.forward));
            }
            if(StoreValue.LBChain >= 2)
            {
                Instantiate(lightningBallPrefab, Ball.position, Quaternion.AngleAxis(45, Vector3.forward));
            }
            if (StoreValue.LBChain >= 3)
            {
                Instantiate(lightningBallPrefab, Ball.position, Quaternion.AngleAxis(0, Vector3.forward));
            }
            if (StoreValue.LBChain >= 4)
            {
                Instantiate(lightningBallPrefab, Ball.position, Quaternion.AngleAxis(-45, Vector3.forward));
            }
            if (StoreValue.LBChain >= 5)
            {
                Instantiate(lightningBallPrefab, Ball.position, Quaternion.AngleAxis(-90, Vector3.forward));
            }
            if (StoreValue.LBChain >= 6)
            {
                Instantiate(lightningBallPrefab, Ball.position, Quaternion.AngleAxis(-135, Vector3.forward));
            }
            if (StoreValue.LBChain >= 7)
            {
                Instantiate(lightningBallPrefab, Ball.position, Quaternion.AngleAxis(180, Vector3.forward));
            }
            if (StoreValue.LBChain >= 8)
            {
                Instantiate(lightningBallPrefab, Ball.position, Quaternion.AngleAxis(135, Vector3.forward));
            }
            Destroy(gameObject);
        }
    }
}

