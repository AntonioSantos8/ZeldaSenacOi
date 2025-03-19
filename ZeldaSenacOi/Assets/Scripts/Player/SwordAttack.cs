using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : MonoBehaviour
{
    List<EnemyStatus> enemiesInRange = new List<EnemyStatus>();

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && enemiesInRange.Count > 0)
        {
            Attack();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            EnemyStatus enemy = collision.GetComponent<EnemyStatus>();
            if (enemy != null && !enemiesInRange.Contains(enemy))
            {
                enemiesInRange.Add(enemy);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            EnemyStatus enemy = collision.GetComponent<EnemyStatus>();
            if (enemy != null)
            {
                enemiesInRange.Remove(enemy);
            }
        }
    }

    void Attack()
    {
        foreach (EnemyStatus enemy in enemiesInRange)
        {
            enemy.TakeDamage(10);
        }
    }
}
