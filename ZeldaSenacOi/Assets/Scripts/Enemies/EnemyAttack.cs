using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : EnemyStatus
{
    PlayerStatus statusPlayer;
    bool canAttack;
    // Start is called before the first frame update
    void Start()
    {
        canAttack = false;
        statusPlayer = FindObjectOfType<PlayerStatus>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!canAttack && collision.CompareTag("Player"))
            StartCoroutine(Attack());
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (canAttack && collision.CompareTag("Player"))
            StopCoroutine(Attack());
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Attack()
    {

        while(attackCooldown > 0)
        {

            statusPlayer.life -= damage;
            attackCooldown--;
            yield return new WaitForSeconds(2);
            attackCooldown = 2;
        }

    }
}
