using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockLBScript : MonoBehaviour {

    public Transform Spot;
    public GameObject FirstShop;
    public GameObject LBShop;
    public int timer;

    // Use this for initialization
    void Start()
    {
        Spot.position = new Vector2(0, 0);
        timer = 5;
    }

    void Update()
    {
        if (timer == 0)
        {
            if (Input.GetButtonDown("Fire1") && Camera.main.ScreenToWorldPoint(Input.mousePosition).x > -116 && Camera.main.ScreenToWorldPoint(Input.mousePosition).x < -86 && Camera.main.ScreenToWorldPoint(Input.mousePosition).y < 43.4 && Camera.main.ScreenToWorldPoint(Input.mousePosition).y > -41)
            {
                Instantiate(FirstShop);
                Destroy(gameObject);
            }

            if (Input.GetButtonDown("Fire1") && Camera.main.ScreenToWorldPoint(Input.mousePosition).x > -86 && Camera.main.ScreenToWorldPoint(Input.mousePosition).x < 115.5 && Camera.main.ScreenToWorldPoint(Input.mousePosition).y < 43.4 && Camera.main.ScreenToWorldPoint(Input.mousePosition).y > -41 && StoreValue.Money >= 500)
            {
                StoreValue.LBUnlock = true;
                StoreValue.Money -= 500;
                Instantiate(LBShop);
                Destroy(gameObject);
            }
        }
        else
        {
            timer--;
        }
    }
}
