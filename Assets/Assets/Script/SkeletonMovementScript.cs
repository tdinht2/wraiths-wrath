using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonMovementScript : MonoBehaviour {
    public Rigidbody2D rb;
    public int health;
    public int speed;
    public int timer;
    public int stunTime;
    public int half;
    public int attack;

	// Use this for initialization
	void Start () {
        speed = speed - (int)(SpawnerScript.wave * .5);
        rb = GetComponent<Rigidbody2D>();
        rb.MovePosition(new Vector2(190, (Random.Range(-65, 65))));
        rb.velocity = new Vector2(speed, 0);
        timer = 0;
    }
    void Update()
    {

        if (timer == 0 && stunTime == 0)
        {
            rb.velocity = new Vector2(speed, 0);
        }
        else if (timer > half)
        {
            rb.velocity = new Vector2(0, 25);
            timer--;
        }
        else if (timer <= half && timer !=0)
        {
            rb.velocity = new Vector2(0, -25);
            timer--;
        }
        else if(stunTime > 0)
        {
            rb.velocity = new Vector2(0, 0);
            stunTime--;
        }
        if (SpawnerScript.waveStarted == false)
        {
            Destroy(gameObject);
        }
        
    }
    void OnCollisionEnter2D(Collision2D hitInfo)
    {
        if (hitInfo.gameObject.name == "Wall")
        {
            BackgroundScript wall = hitInfo.gameObject.GetComponent<BackgroundScript>();
            wall.WallDamage(attack);
            SpawnerScript.enemiesKilled++;
            Destroy(gameObject);
        }
    }
    public void Knockup(int timeInAir)
    {
        timer = timeInAir;
        half = timeInAir / 2;
    }

    public void Stun(int timeStunned)
    {
        stunTime = timeStunned;
    }
}
