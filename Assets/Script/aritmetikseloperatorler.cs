using UnityEngine;

public class aritmetikseloperatorler : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // ------------------ Aritmetik Operatörler ------------------
        int sayi1 = 60, sayi2 = 77, sayi3 = 77;
        int toplam = 0, fark = 0, carpim = 0, mod = 0;
        int bolum = 0;

        toplam = sayi1 + sayi2;
        fark = sayi1 - 10;
        carpim = sayi1 * sayi2;
        bolum = sayi2 / sayi1;
        mod = 10 % 3;

        // ------------------ Karþýlaþtýrma Operatörleri ------------------
        sayi1 = 2;
        sayi2 = 3;

        Debug.Log(sayi1 == sayi2);  // False
        Debug.Log(sayi1 > sayi2);   // False
        Debug.Log(sayi1 < sayi2);   // True
        Debug.Log(sayi1 >= sayi2);  // False
        Debug.Log(sayi1 <= sayi2);  // True
        Debug.Log(sayi1 != sayi2);  // True

        // ------------------ Mantýksal Operatörler ------------------
        sayi1 = 2;
        sayi2 = 3;

        Debug.Log((sayi1 < sayi2) && (sayi1 > 0));  // True
        Debug.Log((sayi1 > sayi2) && (sayi1 > 0));  // False
        Debug.Log((sayi1 > sayi2) || (sayi1 > 0));  // True
        Debug.Log(!(sayi1 > sayi2));               // True
        Debug.Log(!(sayi1 > 0));                   // False

        // ------------------ Atama Operatörleri ------------------
        sayi3 = sayi1; // sayi1'in deðerini sayi3'e atar.

        sayi1 += 1;
        Debug.Log(sayi1); // 3

        sayi2 -= 1;
        Debug.Log(sayi2); // 2

        sayi2 *= 2;
        Debug.Log(sayi2); // 4

        sayi2 /= 2;
        Debug.Log(sayi2); // 2

        // ------------------ Artýrma Operatörleri ------------------
        sayi1 = 2;
        sayi2 = 3;
        sayi3 = 0;

        sayi1++;
        Debug.Log(sayi1); // 3

        sayi2--;
        Debug.Log(sayi2); // 2

        sayi3 = ++sayi1; // sayi1’i 1 artýrýr sonra sayi3'e atar
        Debug.Log(sayi3); // 4

        sayi3 = sayi1++; // sayi1’i sayi3’e atar sonra sayi1’i artýrýr
        Debug.Log(sayi3); // 4
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
