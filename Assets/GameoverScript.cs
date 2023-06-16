using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameoverScript : MonoBehaviour {

    public Transform x;
    public GameObject y;

	// Use this for initialization
	void Start ()
    {
        x.position = new Vector2(0, 25);
    }
	
	void Update ()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(y);
            Destroy(gameObject);
        }

    }
}
