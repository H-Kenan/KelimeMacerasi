using UnityEngine;
using UnityEngine.SceneManagement;

public class KarakterHareketi : MonoBehaviour
{
    public float hareketHizi = 5;
    public float donmeHizi = 550;
    public float ziplamaGucu = 7;
    Rigidbody rb;
    private bool ziplamaYapabilir = true;
    private void Start()
    {
        rb= gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Horizontal sanal ekseninde tanýmlanan sað/sol yön
        // tuþlarýnýn veya A-D tuþlarýnýn kullanýcý bastýðýnda
        // deðiþen Horizontal eksen deðerini alýr.
        float sagaSolaDegeri = Input.GetAxis("Horizontal");

        // Vertical sanal ekseninde tanýmlanan ileri/geri yön
        // tuþlarýnýn veya W-S tuþlarýnýn kullanýcý bastýðýnda
        // deðiþen Vertical eksen deðerini alýr.
        float ileriGeriDegeri = Input.GetAxis("Vertical");

        // Hareket miktarlarýný hesapla
        float xHareket = sagaSolaDegeri * hareketHizi * Time.deltaTime;
        float zHareket = ileriGeriDegeri * hareketHizi * Time.deltaTime;

        // Karakteri X ve Z eksenlerinde hareket ettir
        transform.Translate(new Vector3(xHareket, 0, zHareket));

        // Farenin sol tuþuna basýlý tutuluyorsa
        if (Input.GetMouseButton(0))
        {
            // Fare hareket ettirildiðinde Mouse X isimli eksen ile farenin
            // yatay eksendeki deðiþim deðerini alýr.
            float yataydaFareHareketi = Input.GetAxis("Mouse X");

            // Dönme miktarý hesaplanýr.
            float donmeMiktari = yataydaFareHareketi * donmeHizi * Time.deltaTime;

            // Script dosyasýnýn eklendiði karakter nesnesi Y ekseninde
            // donmeMiktari kadar döndürülür.
            transform.Rotate(Vector3.up, donmeMiktari);
        }
        if (ziplamaYapabilir && Input.GetButtonDown("Jump"))
        {
            Ziplama(ziplamaGucu);
        }
    }

    void Ziplama(float ziplamaGucu)
    {
        rb.AddForce(Vector3.up * ziplamaGucu, ForceMode.Impulse);
        ziplamaYapabilir = false;
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("zemin"))
        {
            ziplamaYapabilir = true;
        }
    }
    public void AnaSahneyeDon()
    {
        SceneManager.LoadScene("AnaSahne");
    }

}
