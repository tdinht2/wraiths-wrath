using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour {


    public Transform firePoint;
    public GameObject fireBallPrefab;
    public static bool canCast;

    // Update is called once per frame
    void Update () {

        if (Input.GetButtonDown("Fire1") && Camera.main.ScreenToWorldPoint(Input.mousePosition).x > -96 && SpawnerScript.wave != 0 && SpawnerScript.waveStarted == true && ManaScript.Mana >= 150)
        {
            canCast = true;
            Fire();

        }
        else
        {
            canCast = false;
        }
		
	}

    void Fire()
    {
        Instantiate(fireBallPrefab, firePoint.position, firePoint.rotation);
        ManaScript.Mana -= 150;
    }
}

