using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Opcije_Skripta : MonoBehaviour
{
    public AudioMixer audiomixer;
    public void ModificirajZvuk(float zvuk)
    {
        audiomixer.SetFloat("Glavni_Zvuk", zvuk);
    }
    public void CijeliEkran(bool Ekran)
    {
        Screen.fullScreen = Ekran;
    }
}
