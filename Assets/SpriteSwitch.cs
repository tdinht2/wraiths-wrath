using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSwitch : MonoBehaviour {

    public Sprite[] Healthsprites;

    // Use this for initialization
    void Start () {
        gameObject.GetComponent<SpriteRenderer>().sprite = Healthsprites[0];
    }
	
	// Update is called once per frame
	void Update () {
		if(BackgroundScript.health == 200)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Healthsprites[0];
        }
        if (BackgroundScript.health >= 185 && BackgroundScript.health < 200)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Healthsprites[1];
        }
        if (BackgroundScript.health >= 170 && BackgroundScript.health < 185)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Healthsprites[2];
        }
        if (BackgroundScript.health >= 160 && BackgroundScript.health < 170)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Healthsprites[3];
        }
        if (BackgroundScript.health >= 150 && BackgroundScript.health < 160)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Healthsprites[4];
        }
        if (BackgroundScript.health >= 140 && BackgroundScript.health < 150)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Healthsprites[5];
        }
        if (BackgroundScript.health >= 130 && BackgroundScript.health < 140)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Healthsprites[6];
        }
        if (BackgroundScript.health >= 120 && BackgroundScript.health < 130)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Healthsprites[7];
        }
        if (BackgroundScript.health >= 110 && BackgroundScript.health < 120)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Healthsprites[8];
        }
        if (BackgroundScript.health >= 100 && BackgroundScript.health < 110)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Healthsprites[9];
        }
        if (BackgroundScript.health >= 90 && BackgroundScript.health < 100)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Healthsprites[10];
        }
        if (BackgroundScript.health >= 80 && BackgroundScript.health < 90)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Healthsprites[11];
        }
        if (BackgroundScript.health >= 70 && BackgroundScript.health < 80)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Healthsprites[12];
        }
        if (BackgroundScript.health >= 60 && BackgroundScript.health < 70)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Healthsprites[13];
        }
        if (BackgroundScript.health >= 50 && BackgroundScript.health < 60)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Healthsprites[14];
        }
        if (BackgroundScript.health >= 40 && BackgroundScript.health < 50)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Healthsprites[15];
        }
        if (BackgroundScript.health >= 30 && BackgroundScript.health < 40)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Healthsprites[16];
        }
        if (BackgroundScript.health >= 15 && BackgroundScript.health < 30)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Healthsprites[17];
        }
        if (BackgroundScript.health > 0 && BackgroundScript.health < 15)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Healthsprites[18];
        }
        if (BackgroundScript.health <= 0)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Healthsprites[19];
        }
    }
}
