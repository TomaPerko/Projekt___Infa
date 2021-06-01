using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class okretanje : MonoBehaviour
{
    //deklariranje komponente AIPath iz asseta sa interneta kako bi preko unitya povezali ovu skriptu sa skriptom AIPatha
    public AIPath aipath;
    void Update()
    {
        //provjerava brzinu kojom se krece sprite te ga okrece u odgovarajucem smjeru
        //brzina je negativna ovisno o smjeru kretanja
        if (aipath.desiredVelocity.x>=0.01f) 
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        else if (aipath.desiredVelocity.x <= 0.01f)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
    }
}
