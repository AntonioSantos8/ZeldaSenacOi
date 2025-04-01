using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booga : EnemyStatus
{
    public Transform player;
    private Vector3 velocity = Vector3.zero;
    Vector2 move;
    private Animator anim;
    public float stopDistance = 10;
    [SerializeField] GameObject particle;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
       
    }

    // Update is called once per frame
    void Update()
    {
        Die();
        FollowPlayer();
    }
    void Die()
    {
        if (life <= 0)
        {
            Instantiate(particle, transform.position, Quaternion.identity);
            Destroy(gameObject);
            PlayerMoney.money += 5;
        }
    }
    
    void FollowPlayer()
    {
        move.x = Input.GetAxisRaw("Horizontal");
        float distance = Vector3.Distance(transform.position, player.position);
        anim.SetFloat("MoveX", move.x);
        
        if (distance > stopDistance) 
        {
            transform.position = Vector3.SmoothDamp(transform.position, player.position, ref velocity, smooth, speed);
        }
        else
        {
            velocity = Vector3.zero;
        }
    }
   
}
