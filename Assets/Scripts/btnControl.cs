using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnControl : MonoBehaviour
{
    Manager manager;
    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.Find("manager").GetComponent<Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void tikla()
    {
        manager.cevapKontrol(gameObject.name);
    }
}
