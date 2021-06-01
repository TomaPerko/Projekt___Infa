using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stvori : MonoBehaviour
{
    public GameObject Picaros;
    public GameObject Streber;
    public GameObject Bandit;
    float i=1;


    // Update is called once per frame
    void Update()
    {
        //stvori lika kojeg je igrac izabrao odnosno o unesenome broju
        //moze se korstiti samo jednom
        if( i==1)
        {
            if(Input.GetKeyDown(KeyCode.Alpha1))
            {
                Instantiate(Picaros, transform.position, transform.rotation);
                i++;
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                Instantiate(Streber, transform.position, transform.rotation);
                i++;
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                Instantiate(Bandit, transform.position, transform.rotation);
                i++;
            }
        }
    }
}
