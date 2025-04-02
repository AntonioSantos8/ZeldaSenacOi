using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booga : EnemyStatus
{
   
  
    Vector2 move;
    private Animator anim;
    
    [SerializeField] GameObject particle;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Die();
     
        Animationn();
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
    void Animationn()
    {
        anim.SetFloat("Move", move.x);
        move.x = Input.GetAxisRaw("Horizontal");
    }
   
   
}
