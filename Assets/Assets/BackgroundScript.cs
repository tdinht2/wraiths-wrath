using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScript : MonoBehaviour {

    public static int health, lastWave;
    public static bool gameOver;
    public GameObject x;

    void Start()
    {
        health = 200;    
    }

    public void WallDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        lastWave = SpawnerScript.wave;
        gameOver = true;
        SpawnerScript.waveStarted = false;
        SpawnerScript.wave = 0;
        SpawnerScript.timer = -1;
        Instantiate(x);
    }

}
