using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class telefon : MonoBehaviour
{
    string yanit;
    Manager manager;
    

    public Text txtBilgi;
    void Start()
    {
        manager = GameObject.Find("manager").GetComponent<Manager>();
        yanit = manager.cevap;

        int rast = Random.Range(1, 4);

        if (rast == 1)
        {
            txtBilgi.text = "Maalesef bu konu da yardımcı olamayacağım";
        }
        else if (rast == 2)
        {
            txtBilgi.text = "Cevap " + yanit + " eminim son kararım.";
        }
        else if (rast == 3)
        {
            int rnd = Random.Range(1, 3);

            if (rnd == 1)
            {
                txtBilgi.text = "Emin değilim ama " + yanit + " olabilir.";
            }
            if (rnd == 2)
            {
                foreach (Button btn in manager.cevap_buttonlari)
                {
                    if (btn.name != yanit)
                    {
                        txtBilgi.text = "Emin değilim ama " + btn.name + " olabilir.";
                        break;
                    }
                }
            }
        }
        manager.btnTelefon.interactable = false;

    }

    public void btnOK()
    {
        gameObject.SetActive(false);
    }
}
