using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stvori : MonoBehaviour
{
    public GameObject Picaros;
    public GameObject Streber;
    public GameObject Bandit;
    float i=1;
    
    void Start()
    {
        
       // Instantiate(Picaros, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
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
