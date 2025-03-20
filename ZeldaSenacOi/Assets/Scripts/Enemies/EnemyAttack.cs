using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    PlayerStatus statusPlayer;
    bool canAttack;
    Coroutine attackRoutine;
    public int damage;
    public int attackCooldown = 2;
    void Start()
    {
        canAttack = true;
        statusPlayer = FindObjectOfType<PlayerStatus>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (canAttack && collision.CompareTag("Player"))
        {
            canAttack = true;
            attackRoutine = StartCoroutine(Attack());
            StartCoroutine(Attack());
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            StopCoroutine(attackRoutine);
            attackRoutine = null;
            canAttack = false;
        }
    }

    IEnumerator Attack()
    {
        while (canAttack)
        {
            statusPlayer.life -= damage;
            yield return new WaitForSeconds(2);
        }
    }
}
