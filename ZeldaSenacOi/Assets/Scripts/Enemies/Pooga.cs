using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pooga : EnemyStatus
{
    public Transform player;
    private Vector3 velocity = Vector3.zero;
    public float stopDistance = 10;
    
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
            Destroy(gameObject);
            PlayerMoney.money += 10;
        }
    }
    void FollowPlayer()
    {
        float distance = Vector3.Distance(transform.position, player.position);

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
