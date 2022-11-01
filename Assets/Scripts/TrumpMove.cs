using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrumpMove : MonoBehaviour
{
    public float speed = 3f;
    float movX, movY;
    private Rigidbody2D rb;

    Vector2 dest = Vector2.zero;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    
    }

    void Update()
    {
        movX = Input.GetAxis("Horizontal") * speed;
        movY = Input.GetAxis("Vertical") * speed;
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2 (movX, movY);
    }




   
}
