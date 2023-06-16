using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numbers : MonoBehaviour {
    public static bool Delete;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        Destroy(gameObject);
        if (SpawnerScript.waveStarted || Delete)
        {
            Destroy(gameObject);
        }
	}
    
    public static void SetDelete(bool del)
    {
        Delete = del;
    }
}
