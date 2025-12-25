using UnityEngine;

public class kararyapilari : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 0 ile 100 arasýnda rastgele bir sayý üretir
        int sayi = Random.Range(0, 101);
        Debug.Log("Sayý = " + sayi);

        // ------------------ Sadece if kullanýmý ------------------
        if (sayi < 50)
        {
            Debug.Log("Sayý 0 ile 50 arasýnda");
        }

        // ------------------ if - else kullanýmý ------------------
        if (sayi < 50)
        {
            Debug.Log("Sayý 0 ile 50 arasýnda");
        }
        else
        {
            Debug.Log("Sayý 50 ile 100 arasýnda");
        }

        // ------------------ if - else if - else kullanýmý ------------------
        if (sayi < 30)
        {
            Debug.Log("Sayý 0 ile 30 arasýnda");
        }
        else if (sayi < 60)
        {
            Debug.Log("Sayý 30 ile 60 arasýnda");
        }
        else
        {
            Debug.Log("Sayý 60 ile 100 arasýnda");
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
