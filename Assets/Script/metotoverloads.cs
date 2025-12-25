using UnityEngine;

public class Denemescript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Parametresiz Metot = " + Topla());
        Debug.Log("Bir parametreli Metot = " + Topla(96));
        Debug.Log("Ýki parametreli Metot = " + Topla(1000, 1));
    }

    public int Topla()
    {
        int sayi1 = 30, sayi2 = 3;
        return (sayi1 + sayi2);
    }

    public int Topla(int sayi1)
    {
        int sayi2 = 3;
        return (sayi1 + sayi2);
    }

    public int Topla(int sayi1, int sayi2)
    {
        return (sayi1 + sayi2);
    }

}
