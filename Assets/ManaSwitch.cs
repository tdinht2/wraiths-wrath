using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManaSwitch : MonoBehaviour {

    public Sprite[] Manasprites;

    
    void Start () {
        gameObject.GetComponent<SpriteRenderer>().sprite = Manasprites[0];
    }
	
	// Update is called once per frame
	void Update () {
		if(ManaScript.Mana >= 2000)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Manasprites[0];
        }
        if (ManaScript.Mana >= 1875 && ManaScript.Mana < 2000)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Manasprites[1];
        }
        if (ManaScript.Mana >= 1750 && ManaScript.Mana < 1875)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Manasprites[2];
        }
        if (ManaScript.Mana >= 1625 && ManaScript.Mana < 1750)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Manasprites[3];
        }
        if (ManaScript.Mana >= 1500 && ManaScript.Mana < 1625)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Manasprites[4];
        }
        if (ManaScript.Mana >= 1400 && ManaScript.Mana < 1500)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Manasprites[5];
        }
        if (ManaScript.Mana >= 1300 && ManaScript.Mana < 1400)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Manasprites[6];
        }
        if (ManaScript.Mana >= 1200 && ManaScript.Mana < 1300)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Manasprites[7];
        }
        if (ManaScript.Mana >= 1100 && ManaScript.Mana < 1200)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Manasprites[8];
        }
        if (ManaScript.Mana >= 1000 && ManaScript.Mana < 1100)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Manasprites[9];
        }
        if (ManaScript.Mana >= 900 && ManaScript.Mana < 1000)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Manasprites[10];
        }
        if (ManaScript.Mana >= 800 && ManaScript.Mana < 900)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Manasprites[11];
        }
        if (ManaScript.Mana >= 700 && ManaScript.Mana < 800)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Manasprites[12];
        }
        if (ManaScript.Mana >= 600 && ManaScript.Mana < 700)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Manasprites[13];
        }
        if (ManaScript.Mana >= 500 && ManaScript.Mana < 600)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Manasprites[14];
        }
        if (ManaScript.Mana >= 400 && ManaScript.Mana < 500)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Manasprites[15];
        }
        if (ManaScript.Mana >= 300 && ManaScript.Mana < 400)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Manasprites[16];
        }
        if (ManaScript.Mana >= 200 && ManaScript.Mana < 300)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Manasprites[17];
        }
        if (ManaScript.Mana >= 100 && ManaScript.Mana < 200)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Manasprites[18];
        }
        if (ManaScript.Mana < 100)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Manasprites[19];
        }
    }
}
