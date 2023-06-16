using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningBall : MonoBehaviour {

    public Transform firePoint;
    public GameObject lightningBallPrefab;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1") && Camera.main.ScreenToWorldPoint(Input.mousePosition).x > -96 && SpawnerScript.wave != 0 && SpawnerScript.waveStarted == true && StoreValue.LBUnlock == true && Fireball.canCast == true) 
        {
            Fire();

        }

    }

    void Fire()
    {
        Instantiate(lightningBallPrefab, firePoint.position, firePoint.rotation);
    }
}
