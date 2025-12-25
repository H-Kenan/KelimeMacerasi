using UnityEngine;
using TMPro;

public class MenuKarakterSec : MonoBehaviour
{
    public TMP_Dropdown karakterDropdown;

    public void KarakteriKaydet()
    {
        string secim = karakterDropdown.options[karakterDropdown.value].text;
        KararAyarlarý.SecilenKarakter = secim;
        Debug.Log("Seçilen karakter: " + secim);
    }
}
