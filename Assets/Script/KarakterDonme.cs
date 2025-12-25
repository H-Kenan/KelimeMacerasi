using UnityEngine;

public class KarakterDonme : MonoBehaviour
{
    public float donmeHizi = 550;

    void Update()
    {
        // Farenin sað tuþu (1) veya orta tuþu (2) basýlý tutuluyorsa
        if (Input.GetMouseButton(1) || Input.GetMouseButton(2))
        {
            // Mouse X eksenindeki yatay hareketi al
            float fareHareketi = Input.GetAxis("Mouse X");

            // Dönme miktarýný hesapla
            float donmeMiktari = fareHareketi * donmeHizi * Time.deltaTime;

            // Nesneyi Y ekseninde döndür
            transform.Rotate(Vector3.up, donmeMiktari);
        }
    }
}
