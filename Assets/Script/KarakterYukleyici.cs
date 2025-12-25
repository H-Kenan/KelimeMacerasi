using UnityEngine;

public class KarakterYukleyici : MonoBehaviour
{
    public GameObject cylinder;
    public GameObject capsule;

    void Start()
    {
        if (KararAyarlarý.SecilenKarakter == "Silindir")
        {
            cylinder.SetActive(true);
            capsule.SetActive(false);
        }
        else
        {
            cylinder.SetActive(false);
            capsule.SetActive(true);
        }
    }
}
