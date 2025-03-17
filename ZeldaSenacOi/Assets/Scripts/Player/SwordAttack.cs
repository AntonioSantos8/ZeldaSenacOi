using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : MonoBehaviour
{
    bool canAttack;
    EnemyStatus enemyStatus;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canAttack && Input.GetMouseButtonDown(0))
        {
            Attack();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            canAttack = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            canAttack = !canAttack;
        }
    }
    void Attack()
    {
        enemyStatus = FindObjectOfType<EnemyStatus>();
        enemyStatus.TakeDamage(10);
    }
}
