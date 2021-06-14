using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class seyirci : MonoBehaviour
{
    string yanit;
    Manager manager;

    public Image[] barlar;

    void Start()
    {
        //manager.btnTelefon.interactable = false;
        manager = GameObject.Find("manager").GetComponent<Manager>();
        yanit = manager.cevap;

        int rnd = Random.Range(1, 3);

        if (rnd == 1)
        {
            float rnd2 = Random.Range(75.0f, 96.0f);

            for (int i = 0; i < manager.cevap_buttonlari.Length; i++)
            {
                if (manager.cevap_buttonlari[i].name == yanit)
                {
                    barlar[i].fillAmount = rnd2 / 100;
                }
                else
                {
                    float rnd3 = Random.Range(1.0f, 8.0f);
                    barlar[i].fillAmount = rnd3 / 100.0f;
                }
            }
        }
        else if (rnd == 2)
        {
            for (int i = 0; i < manager.cevap_buttonlari.Length; i++)
            {
                float rnd3 = Random.Range(1.0f, 33.0f);
                barlar[i].fillAmount = rnd3 / 100.0f;
            }
        }
        manager.btnSeyirci.interactable = false;

    }

    public void btnOK()
    {
        gameObject.SetActive(false);
    }
}
