using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreValue : MonoBehaviour {

    public static int FBDamage, IWDamage, IWTime, LBDamage, LBStun, LBChain, TDamage, TTime, Money;
    public static bool FBPass, IWSlide, TReturn, UpgPop, IceUnlock, LBUnlock, TUnlock, PageUp;
    public static float FBSpeed;
    public GameObject[] numbersList = new GameObject[10];
    public GameObject[] numbersList2 = new GameObject[10];
    public int temp1;

    void Start()
    {
        FBDamage = 20;
        FBSpeed = 150;
        IWDamage = 5;
        IWTime = 100;
        LBDamage = 10;
        LBStun = 0;
        LBChain = 0;
        TDamage = 5;
        TTime = 30;
        Money = 250;
        FBPass = false;
        IWSlide = false;
        TReturn = false;
        IceUnlock = false;
        LBUnlock = false;
        TUnlock = false;
    }

    void Update()
    {
        if (!SpawnerScript.waveStarted && SpawnerScript.wave != 0)
        {
            DisplayMoney();
        }
        DisplayWaves();
        
    }

    public void DisplayMoney()
    {

        numbers.SetDelete(true);
        int timer = 10;
        while (timer > 0)
            timer--;
        numbers.SetDelete(false);
        int temp = Money;
        int digit = 0;
        int numDigits = 0;
        Vector2 point = new Vector2(120, 48);
        while (temp > 0)
        {
            digit = temp % 10;
            point.x = 120 - (5 * numDigits);
            Instantiate(numbersList[digit], point, Quaternion.AngleAxis(0, Vector3.forward));
            numDigits++;
            temp /= 10;
        }
        if (Money == 0)
        {
            Instantiate(numbersList[0], point, Quaternion.AngleAxis(0, Vector3.forward));
        }
    }

    public void DisplayWaves()
    {
        if (BackgroundScript.gameOver != true)
        {
            Numbers2.SetDelete1(true);
            int timer2 = 10;
            while (timer2 > 0)
                timer2--;
            Numbers2.SetDelete1(false);
            temp1 = SpawnerScript.wave;
            int digit1 = 0;
            int numDigits1 = 0;
            Vector2 point1 = new Vector2(125, 70);
            while (temp1 > 0)
            {
                digit1 = temp1 % 10;
                point1.x = 125 - (5 * numDigits1);
                Instantiate(numbersList2[digit1], point1, Quaternion.AngleAxis(0, Vector3.forward));
                numDigits1++;
                temp1 /= 10;
            }
        }
        else
        {
            Numbers2.SetDelete1(true);
            int timer2 = 10;
            while (timer2 > 0)
                timer2--;
            Numbers2.SetDelete1(false);
            temp1 = BackgroundScript.lastWave;
            int digit1 = 0;
            int numDigits1 = 0;
            Vector2 point1 = new Vector2(125, 70);
            while (temp1 > 0)
            {
                digit1 = temp1 % 10;
                point1.x = 125 - (5 * numDigits1);
                Instantiate(numbersList2[digit1], point1, Quaternion.AngleAxis(0, Vector3.forward));
                numDigits1++;
                temp1 /= 10;
            }
        }
    }
}
