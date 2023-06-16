using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldOutScri : MonoBehaviour {

    public Transform x;

	// Use this for initialization
	void Start () {
        x.position = new Vector2(-230, 0);
    }
	
	// Update is called once per frame
	void Update () {
        if (StoreValue.UpgPop == true)
        {
            if (StoreValue.FBPass == true && InsideFBShop.FBshop == true)
            {
                x.position = new Vector2(74.4f, 0);
            }
            if (StoreValue.IWSlide == true && InsideIWShop.IWShop == true)
            {
                x.position = new Vector2(74.4f, 0);
            }
            if (StoreValue.LBChain >= 8 && InsideLBShopScript.LBShop == true)
            {
                x.position = new Vector2(74.4f, 0);
            }
            if (StoreValue.TReturn == true && InsideTShop.TShop == true)
            {
                x.position = new Vector2(74.4f, 0);
            }
        }
        else
        {
            x.position = new Vector2(-230, 0);
        }
    }
}
