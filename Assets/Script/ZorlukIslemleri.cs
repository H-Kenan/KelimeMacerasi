using UnityEngine;
using TMPro;

public class ZorlukIslemleri : MonoBehaviour
{
    public TMP_Dropdown zorlukDropdown;

    void Start()
    {
        // PlayerPrefs’te deðer yoksa default 0 (Orta)
        int kayitliZorluk = PlayerPrefs.GetInt("Zorluk", 0);

        // Dropdown deðerini PlayerPrefs’e göre ayarla
        zorlukDropdown.value = kayitliZorluk;

        Debug.Log("Oyun baþýnda seçilen zorluk = " + kayitliZorluk);
    }

    public void ZorlukKaydet()
    {
        int zorluk = zorlukDropdown.value;

        Debug.Log("Dropdown Deðiþti! Yeni deðer = " + zorluk);

        PlayerPrefs.SetInt("Zorluk", zorluk);
        PlayerPrefs.Save();
    }
}
