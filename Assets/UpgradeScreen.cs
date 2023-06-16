using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeScreen : MonoBehaviour {
    
    public Transform Spot;
    public GameObject a, b, c, d, e, f, g, h, flock, glock, hlock;
    public int timer;


    void Start()
    {
        Spot.position = new Vector2(0, 0);
        StoreValue.UpgPop = false;
        Instantiate(a);
        Instantiate(b);
        Instantiate(c);
        Instantiate(d);
        timer = 5;
        
    }
	
    public void Delete()
    {
        Destroy(GameObject.Find("Fireballshop(Clone)"));
        Destroy(GameObject.Find("IcewallShop(Clone)"));
        Destroy(GameObject.Find("Lightningballshop(Clone)"));
        Destroy(GameObject.Find("TornadoShop(Clone)"));
        Destroy(gameObject);
    }
	
	void Update ()
    {
        if (timer == 0)
        {
            if (Input.GetButtonDown("Fire1") && Camera.main.ScreenToWorldPoint(Input.mousePosition).x > 86.3 && Camera.main.ScreenToWorldPoint(Input.mousePosition).x < 115.5 && Camera.main.ScreenToWorldPoint(Input.mousePosition).y < 43.4 && Camera.main.ScreenToWorldPoint(Input.mousePosition).y > -41)
            {
                Delete();
            }
            if (Input.GetButtonDown("Fire1") && Camera.main.ScreenToWorldPoint(Input.mousePosition).x > -109.5 && Camera.main.ScreenToWorldPoint(Input.mousePosition).x < -68.5 && Camera.main.ScreenToWorldPoint(Input.mousePosition).y < 19 && Camera.main.ScreenToWorldPoint(Input.mousePosition).y > -34)
            {
                Instantiate(e);
                StoreValue.UpgPop = true;
                Delete();
            }
            if (Input.GetButtonDown("Fire1") && Camera.main.ScreenToWorldPoint(Input.mousePosition).x > -60 && Camera.main.ScreenToWorldPoint(Input.mousePosition).x < -20 && Camera.main.ScreenToWorldPoint(Input.mousePosition).y > -34 && Camera.main.ScreenToWorldPoint(Input.mousePosition).y < 19)
            {
                if (StoreValue.IceUnlock == true)
                {
                    Instantiate(f);
                    StoreValue.UpgPop = true;
                    Delete();
                }
                else
                {
                    Instantiate(flock);
                    StoreValue.UpgPop = true;
                    Delete();
                }
            }
            if (Input.GetButtonDown("Fire1") && Camera.main.ScreenToWorldPoint(Input.mousePosition).x > -11.7 && Camera.main.ScreenToWorldPoint(Input.mousePosition).x < 28.9 && Camera.main.ScreenToWorldPoint(Input.mousePosition).y > -34 && Camera.main.ScreenToWorldPoint(Input.mousePosition).y < 19)
            {
                if (StoreValue.LBUnlock == true)
                {
                    Instantiate(g);
                    StoreValue.UpgPop = true;
                    Delete();
                }
                else
                {
                    Instantiate(glock);
                    StoreValue.UpgPop = true;
                    Delete();
                }
            }
            if (Input.GetButtonDown("Fire1") && Camera.main.ScreenToWorldPoint(Input.mousePosition).x > 37.5 && Camera.main.ScreenToWorldPoint(Input.mousePosition).x < 77.4 && Camera.main.ScreenToWorldPoint(Input.mousePosition).y > -34 && Camera.main.ScreenToWorldPoint(Input.mousePosition).y < 19)
            {
                if (StoreValue.TUnlock == true)
                {
                    Instantiate(h);
                    StoreValue.UpgPop = true;
                    Delete();
                }
                else
                {
                    Instantiate(hlock);
                    StoreValue.UpgPop = true;
                    Delete();
                }
            }
        }
        else
        {
            timer--;
        }
    }
}
