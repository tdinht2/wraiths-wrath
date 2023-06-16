using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tornado : MonoBehaviour {

    public Transform firePoint;
    public GameObject TornadoPrefab;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1") && Camera.main.ScreenToWorldPoint(Input.mousePosition).x > -96 && SpawnerScript.wave != 0 && SpawnerScript.waveStarted == true && StoreValue.TUnlock == true && Fireball.canCast)
        {
            Fire();
        }

    }

    void Fire()
    {
        Instantiate(TornadoPrefab, firePoint.position, firePoint.rotation);
    }
}
