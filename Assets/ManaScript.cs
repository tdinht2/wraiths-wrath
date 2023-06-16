using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManaScript : MonoBehaviour {

    public static int Mana;

	void Start () {
        Mana = 2000;	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Mana < 2000)
        {
            Mana += 3;
        }
	}
}
