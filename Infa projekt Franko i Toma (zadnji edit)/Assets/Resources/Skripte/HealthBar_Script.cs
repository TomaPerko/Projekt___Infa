using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar_Script : MonoBehaviour
{
    public Slider slider;
    //vrijednosti koje odreduju boju slidera koji reprezentira healthbar
    //moze ih se modificirati u unityu
    public Gradient gradient;
    public Image fill;
    //funkcije koje postavljaju maximalnu vrijednsot varijable health te njenu trenutnu vrijednost
    //funkcije se pozivaju iz druge skripte koje su medusobno ugnjezdene u objektu u unityu
    public void SetMaxhealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
        fill.color = gradient.Evaluate(1f);
    }
   
    public void SetHealth(int health)
    {
        slider.value = health;
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
