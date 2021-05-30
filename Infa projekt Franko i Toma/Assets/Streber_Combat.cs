using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Streber_Combat : MonoBehaviour
{
    public Animator animator;

    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask Enemy;
    public int AttackDamage = 20;
    public float AttackRate = 0.1f;
    float NextAttacktime = 0f;
    void Update()
    {
        if (Time.time >= NextAttacktime)
        {
            if (Input.GetMouseButtonDown(0))
            {
                NapadStreber();
                NextAttacktime = Time.time + 1f / AttackRate;
            }
        }
    }

    void NapadStreber()
    {
        //Pokrece animaciju napada
        animator.SetTrigger("Attack");
        //provjerava koliko je neprijatelja u sloju Enemy i svakom daje stete 
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, Enemy);
        foreach (Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<Enemy>().TakeDamage(AttackDamage);

        }
    }
}