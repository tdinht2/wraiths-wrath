using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsideIWShop : MonoBehaviour {

    public Transform Spot;
    public GameObject FirstShop;
    public int timer;
    public static bool IWShop;

    // Use this for initialization
    void Start()
    {
        Spot.position = new Vector2(0, 0);
        IWShop = true;
        timer = 5;
    }

    void Update()
    {
        if (timer == 0)
        {
            if (Input.GetButtonDown("Fire1") && Camera.main.ScreenToWorldPoint(Input.mousePosition).x > -116 && Camera.main.ScreenToWorldPoint(Input.mousePosition).x < -86 && Camera.main.ScreenToWorldPoint(Input.mousePosition).y < 43.4 && Camera.main.ScreenToWorldPoint(Input.mousePosition).y > -41)
            {
                Instantiate(FirstShop);
                IWShop = false;
                Destroy(gameObject);
            }

            if (Input.GetButtonDown("Fire1") && Camera.main.ScreenToWorldPoint(Input.mousePosition).x > -86 && Camera.main.ScreenToWorldPoint(Input.mousePosition).x < 31 && Camera.main.ScreenToWorldPoint(Input.mousePosition).y < 43.4 && Camera.main.ScreenToWorldPoint(Input.mousePosition).y > 0 && StoreValue.Money >= 200)
            {
                StoreValue.IWDamage += 5;
                StoreValue.Money -= 200;
                timer = 5;
            }

            if (Input.GetButtonDown("Fire1") && Camera.main.ScreenToWorldPoint(Input.mousePosition).x > -86 && Camera.main.ScreenToWorldPoint(Input.mousePosition).x < 31 && Camera.main.ScreenToWorldPoint(Input.mousePosition).y < 0 && Camera.main.ScreenToWorldPoint(Input.mousePosition).y > -41 && StoreValue.Money >= 200)
            {
                StoreValue.IWTime += 10;
                StoreValue.Money -= 200;
                timer = 5;
            }

            if (Input.GetButtonDown("Fire1") && Camera.main.ScreenToWorldPoint(Input.mousePosition).x > 31 && Camera.main.ScreenToWorldPoint(Input.mousePosition).x < 115.5 && Camera.main.ScreenToWorldPoint(Input.mousePosition).y < 43.4 && Camera.main.ScreenToWorldPoint(Input.mousePosition).y > -41 && StoreValue.Money >= 1000 && StoreValue.IWSlide != true )
            {
                StoreValue.IWSlide = true;
                StoreValue.Money -= 1000;
                timer = 5;
            }
        }
        else
        {
            timer--;
        }
    }
}
