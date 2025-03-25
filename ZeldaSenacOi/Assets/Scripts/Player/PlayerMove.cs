using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : PlayerStatus
{
    Rigidbody2D rb;
    Vector2 move;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
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
        anim.SetFloat("MoveX", move.x);
        anim.SetFloat("MoveY", move.y);
        if (move != Vector2.zero)
        {
            anim.SetFloat("LastMoveX", move.x);
            anim.SetFloat("LastMoveY", move.y);
        }
    }
   
}
