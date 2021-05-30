using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Let : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D _rigidbody;
    void Start()
    {
        _rigidbody.velocity = transform.right * speed;
    }
    private void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
