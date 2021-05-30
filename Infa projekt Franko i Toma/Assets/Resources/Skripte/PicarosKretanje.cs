using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PicarosKretanje : MonoBehaviour
{
    public CharacterController2D controller;
    float HorizontalMove = 0f;
    public float runSpeed = 4f;
    public float jumpForce = 4f;
    private Rigidbody2D _rigidbody;
    public Animator animator;


    public int MaxHealth, CurrentHealth;
    public HealthBar_Script Healthbar;
    //bool jump = false;
    // Update is called once per frame
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();
    }
    
       
        
     
    void Update()
    {
        if (animator.GetBool("Mrtav")==false)
        {
            animator.SetFloat("Speed", Mathf.Abs(HorizontalMove));
            HorizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
            if (Input.GetKeyDown("space") && Mathf.Abs(_rigidbody.velocity.y) < 0.01f)
            {
                _rigidbody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);

            }
            if (Mathf.Abs(_rigidbody.velocity.y) > 0.01f)
            {
                animator.SetBool("IsJumping", true);
                //Debug.Log("SKOK");
            }
            if (Mathf.Abs(_rigidbody.velocity.y) < 0.01f)
            {
                animator.SetBool("IsJumping", false);
                //Debug.Log("NE SKOK");
            }
            if (CurrentHealth <= 0)
            {
                animator.SetBool("Mrtav",true);
                //animator.SetTrigger("Grob");
                //animator.SetBool("Mrtav", false);

            }
            //primanje stete
            if (Input.GetKeyDown(KeyCode.P))
            {
                TakeDamage(20);
            }
            //napadanje
            if (Input.GetMouseButtonDown(0))
            {
                animator.SetTrigger("Shooting");

            }

        }

    }

    private void FixedUpdate()
    {
        controller.Move(HorizontalMove*Time.fixedDeltaTime, false, false);
        //jump = false;
        

    }

    //davanje stete
    public void TakeDamage(int Damage)
    {
        CurrentHealth -= Damage;
        Healthbar.SetHealth(CurrentHealth);

    }
}
