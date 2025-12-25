using UnityEngine;

public class yondegerleri : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Klavyeden sað-sol yön tuþlarý veya A-D tuþlarýna basýldýðýnda
        // gelen yatay eksen deðeri (sol = -1, sað = +1)
        float sagaSolaDegeri = Input.GetAxis("Horizontal");
        Debug.Log("Yataydaki Sað-Sol Deðeri: " + sagaSolaDegeri);

        // Space tuþu basýlýyken
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Space tuþuna basýlýyor");
        }

        // Backspace tuþuna bir kere basýldýðýnda (tek tetikleme)
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("Geri tuþuna basýldý");
        }
    }

}
