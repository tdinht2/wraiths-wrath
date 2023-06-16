using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsideLBShopScript : MonoBehaviour
{

    public Transform Spot;
    public GameObject FirstShop;
    public int Timer;
    public static bool LBShop;

    // Use this for initialization
    void Start()
    {
        Spot.position = new Vector2(0, 0);
        LBShop = true;
        Timer = 5;
    }

    void Update()
    {
        if (Timer == 0)
        {

            if (Input.GetButtonDown("Fire1") && Camera.main.ScreenToWorldPoint(Input.mousePosition).x > -116 && Camera.main.ScreenToWorldPoint(Input.mousePosition).x < -86 && Camera.main.ScreenToWorldPoint(Input.mousePosition).y < 43.4 && Camera.main.ScreenToWorldPoint(Input.mousePosition).y > -41)
            {
                Instantiate(FirstShop);
                LBShop = false;
                Destroy(gameObject);
            }

            if (Input.GetButtonDown("Fire1") && Camera.main.ScreenToWorldPoint(Input.mousePosition).x > -86 && Camera.main.ScreenToWorldPoint(Input.mousePosition).x < 31 && Camera.main.ScreenToWorldPoint(Input.mousePosition).y < 43.4 && Camera.main.ScreenToWorldPoint(Input.mousePosition).y > 0 && StoreValue.Money >= 200)
            {
                StoreValue.LBDamage = StoreValue.LBDamage + 5;
                StoreValue.Money -= 200;
                Timer = 5;
            }

            if (Input.GetButtonDown("Fire1") && Camera.main.ScreenToWorldPoint(Input.mousePosition).x > -86 && Camera.main.ScreenToWorldPoint(Input.mousePosition).x < 31 && Camera.main.ScreenToWorldPoint(Input.mousePosition).y < 0 && Camera.main.ScreenToWorldPoint(Input.mousePosition).y > -41 && StoreValue.Money >= 200)
            {
                StoreValue.LBStun += 10;
                StoreValue.Money -= 200;
                Timer = 5;
            }

            if (Input.GetButtonDown("Fire1") && Camera.main.ScreenToWorldPoint(Input.mousePosition).x > 31 && Camera.main.ScreenToWorldPoint(Input.mousePosition).x < 115.5 && Camera.main.ScreenToWorldPoint(Input.mousePosition).y < 43.4 && Camera.main.ScreenToWorldPoint(Input.mousePosition).y > -41 && StoreValue.Money >= 125 && StoreValue.LBChain < 8)
            {
                StoreValue.LBChain++;
                StoreValue.Money -= 125;
                Timer = 5;
            }
        }
        else
        {
            Timer--;
        }
    }
}
	
	
