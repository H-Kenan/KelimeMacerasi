using System.Collections.Generic;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int sayi1 = 77; // sayi1 deðiþkeni tanýmlanmýþ ve deðeri hemen 
                        // atanmýþtýr.

        int sayi2;  // sayi2 deðiþkeni tanýmlanmýþtýr.
        sayi2 = 60; // Deðeri sonradan atanmýþtýr.

        // iller dizisi tanýmlanmýþ ve deðerleri hemen atanmýþtýr.
        string[] iller = new string[] { "Yalova", "Tokat", "Tekirdað" };

        // sayýlar dizisi tanýmlanmýþ ve deðerleri sonradan atanmýþtýr.
        int[] sayilar = new int[3];
        sayilar[0] = 9;
        sayilar[1] = 8;
        sayilar[2] = 3;

        // sayilar2 listesi tanýmlanmýþ ve deðerleri hemen atanmýþtýr.
        List<int> sayilar2 = new() { 1, 2, 3 };

        // iller2 listesi tanýmlanmýþ ve deðerleri sonradan atanmýþtýr.
        List<string> iller2 = new();
        iller2.Add("Ýstanbul");
        iller2.Add("Bursa");
        iller2.Add("Konya ");

        Debug.Log("sayi2 = " + sayi2);
        Debug.Log("iller dizisinin 2.Elemaný = " + iller[1]);
        Debug.Log("iller2 listesinin 3.Elemaný = " + iller2[2]);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
