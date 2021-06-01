using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luk_I_Strijela : MonoBehaviour
{
    //deklariramo poziciju(transform) child objecta koji je vezan za igraca u unityu kako bi ga pratio
    //te kako bi tu tocku koristili za ispaljivanje strijela
    public Transform tockaPucanja;
    public GameObject prefabStrijela;
    public float Napad = 2f;
    float VrijemeDoNapada = 0f;
    void Update()
    {
        //provjerava jeli proslo dovoljno vremena kako bi mogli ponovno napasti
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
        //stvara GameObject kojeg smo stvorili i povezali u unityu te ga stavlja na istu poziciju i rotaciju kao tocku pucanja
        Instantiate(prefabStrijela,tockaPucanja.position,tockaPucanja.rotation);
    }
}
