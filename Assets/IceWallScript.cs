using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceWallScript : MonoBehaviour
{

    public int damage = 100;
    public int timer;
    public GameObject x;
    public Transform y;

    void Start()
    {
        damage = StoreValue.IWDamage;
        timer = StoreValue.IWTime;
    }

    void Update()
    {
        if (timer == 0)
        {
            if(StoreValue.IWSlide == true)
            {
                Instantiate(x, y.position, y.rotation);
            }
            Destroy(gameObject);
        }
        else
        {
            timer--;
        }

    }
    void OnCollisionEnter2D(Collision2D hitInfo)
    {
        if (hitInfo.gameObject.tag == "ProjectileWall")
        {
            Destroy(gameObject);
        }
        else if (hitInfo.gameObject.tag == "Enemy")
        {
            Damage enemy = hitInfo.gameObject.GetComponent<Damage>();
            enemy.TakeDamage(damage);
        }
    }


}
