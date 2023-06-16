using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPage : MonoBehaviour {

    public Transform x;

	// Use this for initialization
	void Start () {
        StoreValue.PageUp = true;
        x.position = new Vector2(-5, -5);
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            StoreValue.PageUp = false;
            Destroy(gameObject);
        }

    }
}
