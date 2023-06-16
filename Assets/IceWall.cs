using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceWall : MonoBehaviour {

    public GameObject IceWallPrefab;
    public Vector3 mousePosition;

    // Update is called once per frame
    void Update () {
        if (Input.GetButtonDown("Fire1") && Camera.main.ScreenToWorldPoint(Input.mousePosition).x > -96 && SpawnerScript.wave != 0 && SpawnerScript.waveStarted == true && StoreValue.IceUnlock == true && Fireball.canCast == true)
        {
            mousePosition = Input.mousePosition;
            mousePosition.z = 10;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            Fire();

        }
    }

    public void Fire()
    {
        Instantiate(IceWallPrefab, mousePosition, Quaternion.AngleAxis(0, Vector3.forward));
    }
}
