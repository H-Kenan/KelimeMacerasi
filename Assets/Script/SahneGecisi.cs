using System.Collections.Generic;
using UnityEngine;
using TMPro;

using UnityEngine.SceneManagement; // Sahne iþlemleri için gerekli

public class SahneGecisi : MonoBehaviour
{
    // Karakter ve zorluk dropdownlarýný tutacak olan deðiþkenler
    public TMP_Dropdown karakter, zorluk;
    public int zorlukSeviyesi;

    void Start()
    {
        // Karakter seçeneðini PlayerPrefs’ten al, yoksa 0
        int saklananKarakterSecenegi = PlayerPrefs.GetInt("karakterSecenegi", 0);

        // Karakter dropdown’ýnda saklanan deðeri ayarla
        karakter.value = saklananKarakterSecenegi;

        zorlukSeviyesi = PlayerPrefs.GetInt("Zorluk", 0);
        Debug.Log("Seçilen Zorluk = " + zorlukSeviyesi);
    }

    public void SahneDegistir(string sahneAdi)
    {
        PlayerPrefs.SetInt("karakterSecenegi",karakter.value);
        PlayerPrefs.Save();
        SceneManager.LoadScene(sahneAdi);
    }
    public void OyunuKapat()
    {
        Application.Quit();
    }
}
