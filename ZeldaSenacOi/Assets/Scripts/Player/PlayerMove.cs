using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : PlayerStatus
{
    Rigidbody2D rb;
    
    Vector2 move;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    private void FixedUpdate()
    {
        rb.velocity = move * moveSpeed;
    }
    void Move()
    {
        move.x = Input.GetAxisRaw("Horizontal");
        move.y = Input.GetAxisRaw("Vertical");
        move.Normalize();
    }
   
}
