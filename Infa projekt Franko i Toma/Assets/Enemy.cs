using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Animator animator;
    [SerializeField] private int MaxHealth;
    public int CurrentHealth;
    void Start()
    {
        CurrentHealth = MaxHealth;
    }

    public void TakeDamage(int damage)
    {
        CurrentHealth = CurrentHealth - damage;

        animator.SetTrigger("IsHurt");
        if (CurrentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        animator.SetBool("ISDead", true);
        GetComponent<Collider2D>().enabled = false;
        GetComponent<Rigidbody2D>().gravityScale = 0;
        this.enabled = false;
    }
}
