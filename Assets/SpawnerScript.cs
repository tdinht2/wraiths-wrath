using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour {
    public static int wave;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;
    public GameObject enemy5;

    public Transform SpawnerOrigin;
    public static bool waveStarted;
    public int numEnemies;
    public static int enemiesKilled;
    public int enemiesSpawned;
    public static int timer;
    public GameObject UpgradeScreen;
    public int randomX;

	// Use this for initialization
	void Start () {
        waveStarted = false;
        wave = 0;
        timer = -1;
        //Instantiate(skeltal, SpawnerOrigin.position, Quaternion.AngleAxis(0, Vector3.forward));
    }
	
    public void StartWave()
    {
        waveStarted = true;
        wave++;
        timer = 25;
        numEnemies = (int)(wave * 1.5) + 10;
        enemiesSpawned = 0;
        enemiesKilled = 0;
    }
	// Update is called once per frame
	void Update () {

        if (waveStarted)
        {
            if (enemiesKilled >= numEnemies)
            {
                Instantiate(UpgradeScreen, SpawnerOrigin.position, Quaternion.AngleAxis(0, Vector3.forward));
                waveStarted = false;
                StoreValue.Money += 250;
                ManaScript.Mana = 2000;
            }
        }
        if(!waveStarted && BackgroundScript.gameOver != true && Camera.main.ScreenToWorldPoint(Input.mousePosition).x > 86.3 && Camera.main.ScreenToWorldPoint(Input.mousePosition).x < 115.5 && Camera.main.ScreenToWorldPoint(Input.mousePosition).y < 43.4 && Camera.main.ScreenToWorldPoint(Input.mousePosition).y > -41 && StoreValue.UpgPop != true) 
        {
            if (Input.GetButtonDown("Fire1"))
                StartWave();
        }
        if (enemiesSpawned < numEnemies)
        {
            if (timer == 0 && BackgroundScript.gameOver != true)
            {
                if (wave == 1)
                {
                    Instantiate(enemy1, SpawnerOrigin.position, Quaternion.AngleAxis(0, Vector3.forward));
                    timer = Random.Range(40, Mathf.Max(90, (250 - (10 * wave))));
                    enemiesSpawned++;
                }
                if (wave > 1 && wave < 4)
                {
                    randomX = Random.Range(1, 4);
                    if (randomX < 3)
                    {
                        Instantiate(enemy1, SpawnerOrigin.position, Quaternion.AngleAxis(0, Vector3.forward));
                        timer = Random.Range(40, Mathf.Max(90, (250 - (10 * wave))));
                        enemiesSpawned++;
                    }
                    else
                    {
                        Instantiate(enemy2, SpawnerOrigin.position, Quaternion.AngleAxis(0, Vector3.forward));
                        timer = Random.Range(40, Mathf.Max(90, (250 - (10 * wave))));
                        enemiesSpawned++;
                    }
                }
                if (wave == 4)
                {
                    randomX = Random.Range(1, 11);
                    if(randomX < 6)
                    {
                        Instantiate(enemy1, SpawnerOrigin.position, Quaternion.AngleAxis(0, Vector3.forward));
                        timer = Random.Range(40, Mathf.Max(90, (250 - (10 * wave))));
                        enemiesSpawned++;
                    }
                    if(randomX == 6 || randomX == 7 || randomX == 8)
                    {
                        Instantiate(enemy2, SpawnerOrigin.position, Quaternion.AngleAxis(0, Vector3.forward));
                        timer = Random.Range(40, Mathf.Max(90, (250 - (10 * wave))));
                        enemiesSpawned++;
                    }
                    if(randomX > 8)
                    {
                        Instantiate(enemy4, SpawnerOrigin.position, Quaternion.AngleAxis(0, Vector3.forward));
                        timer = Random.Range(40, Mathf.Max(90, (250 - (10 * wave))));
                        enemiesSpawned++;
                    }
                }
                if (wave > 4 && wave < 8)
                {
                    randomX = Random.Range(1, 11);
                    if (randomX < 6)
                    {
                        Instantiate(enemy1, SpawnerOrigin.position, Quaternion.AngleAxis(0, Vector3.forward));
                        timer = Random.Range(40, Mathf.Max(90, (250 - (10 * wave))));
                        enemiesSpawned++;
                    }
                    if (randomX == 6 || randomX == 7)
                    {
                        Instantiate(enemy2, SpawnerOrigin.position, Quaternion.AngleAxis(0, Vector3.forward));
                        timer = Random.Range(40, Mathf.Max(90, (250 - (10 * wave))));
                        enemiesSpawned++;
                    }
                    if (randomX == 8)
                    {
                        Instantiate(enemy4, SpawnerOrigin.position, Quaternion.AngleAxis(0, Vector3.forward));
                        timer = Random.Range(40, Mathf.Max(90, (250 - (10 * wave))));
                        enemiesSpawned++;
                    }
                    if (randomX > 8)
                    {
                        Instantiate(enemy5, SpawnerOrigin.position, Quaternion.AngleAxis(0, Vector3.forward));
                        timer = Random.Range(40, Mathf.Max(90, (250 - (10 * wave))));
                        enemiesSpawned++;
                    }
                }
                if (wave >= 8)
                {
                    randomX = Random.Range(1, 21);
                    if (randomX < 11)
                    {
                        Instantiate(enemy1, SpawnerOrigin.position, Quaternion.AngleAxis(0, Vector3.forward));
                        timer = Random.Range(40, Mathf.Max(90, (250 - (10 * wave))));
                        enemiesSpawned++;
                    }
                    if (randomX >= 11 && randomX < 14)
                    {
                        Instantiate(enemy2, SpawnerOrigin.position, Quaternion.AngleAxis(0, Vector3.forward));
                        timer = Random.Range(40, Mathf.Max(90, (250 - (10 * wave))));
                        enemiesSpawned++;
                    }
                    if (randomX == 14 || randomX == 15)
                    {
                        Instantiate(enemy4, SpawnerOrigin.position, Quaternion.AngleAxis(0, Vector3.forward));
                        timer = Random.Range(40, Mathf.Max(90, (250 - (10 * wave))));
                        enemiesSpawned++;
                    }
                    if (randomX == 16 || randomX == 17 || randomX == 18)
                    {
                        Instantiate(enemy5, SpawnerOrigin.position, Quaternion.AngleAxis(0, Vector3.forward));
                        timer = Random.Range(40, Mathf.Max(90, (250 - (10 * wave))));
                        enemiesSpawned++;
                    }
                    if (randomX == 19|| randomX == 20)
                    {
                        Instantiate(enemy3, SpawnerOrigin.position, Quaternion.AngleAxis(0, Vector3.forward));
                        timer = Random.Range(40, Mathf.Max(90, (250 - (10 * wave))));
                        enemiesSpawned++;
                    }
                }
            }
            else
            {
                timer--;
            }
        }
	}

    public void KillEnemy()
    {
        enemiesKilled++;
    }
}
