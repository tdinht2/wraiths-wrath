using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TornadoScript : MonoBehaviour {
    public float speed = -100f;
    public Rigidbody2D rb;
    public int damage = 10;
    public GameObject ReturnTornado;
    public Transform location;
    public int Knockuptime;
   

    // Use this for initialization
    void Start()
    {
        rb.velocity = transform.right * speed;
        damage = StoreValue.TDamage;
        Knockuptime = StoreValue.TTime;
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
            enemy2.Knockup(Knockuptime);

        }
        else if (hitInfo.tag == "ReturnTornadoWall" && StoreValue.TReturn == true)
        {
            Instantiate(ReturnTornado, location.position, Quaternion.AngleAxis(0, Vector3.forward));
            Destroy(gameObject);
        }
    }
}
