using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luk_I_Strijela : MonoBehaviour
{
    public Transform tockaPucanja;
    public GameObject prefabStrijela;
    public float Napad = 2f;
    float VrijemeDoNapada = 0f;
    void Update()
    {
        if(Time.time>=VrijemeDoNapada)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Pucaj();
                VrijemeDoNapada = Time.time + 1f / Napad;
            }
        }
        
    }
    void Pucaj()
    {
        Instantiate(prefabStrijela,tockaPucanja.position,tockaPucanja.rotation);
    }
}
