using UnityEngine;

public class CevapKontrol : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // ENGEL ile çarpýþtýysa
        if (collision.gameObject.CompareTag("Engel"))
        {
            Debug.Log("Engele Çarptýnýz!");
        }

        // DOÐRU CEVAP ile çarpýþtýysa
        if (collision.gameObject.CompareTag("Dogru"))
        {
            Debug.Log("Doðru Cevap");
        }

        // YANLIÞ CEVAP ile çarpýþtýysa
        if (collision.gameObject.CompareTag("Yanlis"))
        {
            Debug.Log("Yanlýþ Cevap");
        }
    }
}
