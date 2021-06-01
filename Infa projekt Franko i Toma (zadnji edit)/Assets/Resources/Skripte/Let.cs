using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Let : MonoBehaviour
{
    public float speed = 20f;
    //rigidbody2D je komponenta koja omogucuje objektu da na na njega utjece fizika te nam omogucuje da je modificiramo
    public Rigidbody2D _rigidbody;
    void Start()
    {
        //objektu tj. spriteu strijele daje konstantnu brzinu u jednome smjeru
        _rigidbody.velocity = transform.right * speed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //kada strijela dotakne bilo koju komponentu sa kojom se moze sudariti je unistavamo kako nebi nstavila letjeti beskonacno
        Destroy(gameObject);
    }
}
