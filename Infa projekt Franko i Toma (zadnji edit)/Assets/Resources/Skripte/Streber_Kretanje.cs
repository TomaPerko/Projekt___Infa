using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Streber_Kretanje : MonoBehaviour
{
    //deklariranje svih stvari koje su nam potrebne kako bi kretanje bilo fluidno
    //i povezano sa animacijama te kako bi moglo imati interakciju sa ostatkom svijeta
    public CharacterController2D controller;
    float HorizontalMove = 0f;
    public float runSpeed = 4f;
    public float jumpForce = 4f;
    private Rigidbody2D _rigidbody;
    public Animator animator;

    //deklarianje varijabli i skripte koju cemo povezati u unityu sa drugom skriptom koja upravlja sa objectom slidera
    public int MaxHealth, CurrentHealth;
    public HealthBar_Script Healthbar;
    // Update is called once per frame
    private void Start()
    {
        //postavlja varijable na vrijednosti pozvane iz unitya kako bi
        //se kasnije u skripti mogli referirati na to te ih korsititi po potrebi
        _rigidbody = GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();
    }
    void Update()
    {
        //provjerava jeli igrac mrtav te mu onemogucuje kretanje u slucaju da je
        if (animator.GetBool("Mrtav")==false)
        {
            //Stvarna brzina igraca i parametar "Speed" u animatoru nisu povezani
            //a bitni su kako bi znali kada se treba pustiti koja animacija
            //te zbpog toga konstantno postavljamo vrijednost parametra "Speed" na stvarnu brzinu igraca
            animator.SetFloat("Speed", Mathf.Abs(HorizontalMove));



            //postavlja brzinu igraca na vrijednost koja je odredena u unityu
            HorizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

            //provjerava jeli igrac stisnuo tipku space te jeli se njegova visina povecala te tjera igraca da skace
            if (Input.GetKeyDown("space") && Mathf.Abs(_rigidbody.velocity.y) < 0.01f)
            {
                _rigidbody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);

            }



            //daje do znanja aniamtoru koju animaciju da pusti ovisno o tome skace li igrac ili ne
            if (Mathf.Abs(_rigidbody.velocity.y) > 0.01f)
            {
                animator.SetBool("IsJumping", true);
            }
            if (Mathf.Abs(_rigidbody.velocity.y) < 0.01f)
            {
                animator.SetBool("IsJumping", false);
            }


            //provjerava jeli igrac ziv kako bi pustili odredenu animaciju
            if (CurrentHealth <= 0)
            {
                animator.SetBool("Mrtav",true);
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
        //podesava brzinu igraca kako bi se na svakome uredaju kretao istom brzinom jer se igra odvija razlicitim brzinama ovisno o jacini uredaja
        //time se igra odvija na vecem broju frameova po sekundi te bi se tako igrac kretao brze na boljim uredajima
        //varijabla fixeddeltatime ponistava ta razlike
        controller.Move(HorizontalMove * Time.fixedDeltaTime, false, false);
    }
    //davanje stete
    public void TakeDamage(int Damage)
    {
        CurrentHealth -= Damage;
        Healthbar.SetHealth(CurrentHealth);

    }

}
