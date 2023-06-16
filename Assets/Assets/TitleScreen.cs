using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScreen : MonoBehaviour {
    public Transform trans;
    public GameObject instructions;
    public GameObject credits;
    public int Timer;

    // Use this for initialization
    void Start () {

        trans.position = new Vector2(0, 0);
        Timer = 5;
        BackgroundScript.health = 200;
        BackgroundScript.gameOver = true;
        ManaScript.Mana = 2000;
        StoreValue.FBDamage = 20;
        StoreValue.FBSpeed = 150;
        StoreValue.IWDamage = 0;
        StoreValue.IWTime = 100;
        StoreValue.LBDamage = 10;
        StoreValue.LBStun = 0;
        StoreValue.LBChain = 0;
        StoreValue.TDamage = 5;
        StoreValue.TTime = 30;
        StoreValue.Money = 250;
        StoreValue.FBPass = false;
        StoreValue.IWSlide = false;
        StoreValue.TReturn = false;
        StoreValue.IceUnlock = false;
        StoreValue.LBUnlock = false;
        StoreValue.TUnlock = false;
        StoreValue.PageUp = false;
        SpawnerScript.waveStarted = false;
        SpawnerScript.wave = 0;
        SpawnerScript.timer = -1;
    }
	
	// Update is called once per frame
	void Update () {
        if (Timer == 0)
        {

            if (Input.GetButtonDown("Fire1") && StoreValue.PageUp == false && Camera.main.ScreenToWorldPoint(Input.mousePosition).x > -27.5 && Camera.main.ScreenToWorldPoint(Input.mousePosition).x < 27 && Camera.main.ScreenToWorldPoint(Input.mousePosition).y > -15 && Camera.main.ScreenToWorldPoint(Input.mousePosition).y < 7)
            {
                BackgroundScript.gameOver = false;
                SpawnerScript x = GameObject.Find("Spawner").GetComponent<SpawnerScript>();
                x.StartWave();
                Destroy(gameObject);
            }
            if (Input.GetButtonDown("Fire1") && StoreValue.PageUp == false && Camera.main.ScreenToWorldPoint(Input.mousePosition).x > -46 && Camera.main.ScreenToWorldPoint(Input.mousePosition).x < 47 && Camera.main.ScreenToWorldPoint(Input.mousePosition).y > -41 && Camera.main.ScreenToWorldPoint(Input.mousePosition).y < -21)
            {
                Instantiate(credits);
            }
            if (Input.GetButtonDown("Fire1") && StoreValue.PageUp == false && Camera.main.ScreenToWorldPoint(Input.mousePosition).x > -86 && Camera.main.ScreenToWorldPoint(Input.mousePosition).x < 90 && Camera.main.ScreenToWorldPoint(Input.mousePosition).y > -70 && Camera.main.ScreenToWorldPoint(Input.mousePosition).y < -48)
            {
                Instantiate(instructions);
            }
        }
        else
        {
            Timer--;
        }
    }
}
