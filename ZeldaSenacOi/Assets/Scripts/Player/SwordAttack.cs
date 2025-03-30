using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SwordAttack : MonoBehaviour
{
    List<EnemyStatus> enemiesInRange = new List<EnemyStatus>();
    public bool canAttack;
    [SerializeField]int damage;
    [SerializeField] int coodown;
    private void Start()
    {
        canAttack = true;
    }

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
        SwordAim swordAim = FindObjectOfType<SwordAim>();
        if (swordAim != null)
        {
            swordAim.AnimationSword(); 
        }

        StartCoroutine(CooldownSword());

        foreach (EnemyStatus enemy in enemiesInRange)
        {
            enemy.TakeDamage(damage);
        }
    }

    IEnumerator CooldownSword()
    {
        canAttack = false;
        yield return new WaitForSeconds(coodown);
        canAttack = true;
    }
}
