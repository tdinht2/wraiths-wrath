using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Numbers2 : MonoBehaviour {
    public static bool Delete2;

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject);
        if (Delete2)
        {
            Destroy(gameObject);
        }
    }

    public static void SetDelete1(bool del)
    {
        Delete2 = del;
    }
}
