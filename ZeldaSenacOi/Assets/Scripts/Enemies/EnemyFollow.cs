using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public Transform player;
    private Vector3 velocity = Vector3.zero;
    private bool isInRange = false;
    public float smooth = 0.3f;
    private Transform enemy;

    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        enemy = transform.parent; 
    }

    void Update()
    {
        FollowPlayer();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isInRange = false;
        }
    }

    void FollowPlayer()
    {
        if (isInRange && enemy != null)
        {
            enemy.position = Vector3.SmoothDamp(enemy.position, player.position, ref velocity, smooth);
        }
        else
        {
            velocity = Vector3.zero;
        }
    }
}
