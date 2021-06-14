using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public TextMeshProUGUI soru_txt;
    public TextAsset metin_belgesi;
    public Image[] Odul;
    public Button[] cevap_buttonlari;
    public GameObject PnlKaybettin;
    public GameObject PnlSeyirci;
    public GameObject PnlTelefon;
    Button btnYariJoker;
    public Button btnTelefon;
    public Button btnSeyirci;
    public string cevap;
    int ilksatir = 0;
    int sonsatir = 5;
    int dogrucevap = 0;
    string[] sorular;
    // Start is called before the first frame update
    void Start()
    {
        btnYariJoker = GameObject.Find("Yari_Joker").GetComponent<Button>();
        sorular = metin_belgesi.text.Split("\n"[0]);
        soru_ekle(ilksatir, sonsatir);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void soru_ekle(int ilk, int son)
    {
        soru_txt.text = sorular[ilk];
        cevap = sorular[son];


        for (int i = 0; i < 4; i++)
        {
            cevap_buttonlari[i].name = sorular[ilk + (i+1)];
            cevap_buttonlari[i].GetComponentInChildren<TextMeshProUGUI>().text = sorular[ilk + (i + 1)];
        }
        
    }

    public void cevapKontrol(string deger)
    {
        if (deger == cevap)
        {
            Debug.Log("Doğru");

            Odul[dogrucevap].color = Color.green;

            ilksatir = sonsatir + 1;
            sonsatir = ilksatir + 5;

            soru_ekle(ilksatir, sonsatir);
            dogrucevap++;
        }
        else
        {
            Debug.LogError("Yanlış");
            PnlKaybettin.SetActive(true);
        }
    }

    public void tekrarOyna()
    {
        SceneManager.LoadScene(0);
    }

    public void yariJoker()
    {
        btnYariJoker.interactable = false;
        Debug.LogError("Tıklandı");
        int silinenCevap = 0;

        foreach (Button item in cevap_buttonlari)
        {
            if (silinenCevap == 2)
            {
                break;
            }
            if (item.name != cevap)
            {
                item.GetComponentInChildren<TextMeshProUGUI>().text = null;
                silinenCevap++;
            }

            
        }
    }

    public void telefon_joker()
    {
        PnlTelefon.SetActive(true); 
    }
    public void seyirci_joker()
    {
        PnlSeyirci.SetActive(true); 
    }
}
