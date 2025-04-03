using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaFogo : MonoBehaviour
{
    public float speed = 10f;
    public int damage = 20;
    public float lifetime = 5f;
    private Vector3 moveDirection;
    public Animator anim;
    public void SetDirection(Vector3 direction)
    {
        moveDirection = direction.normalized;
    }
    private void Start()
    {
        anim.SetTrigger("Joguei");
        StartCoroutine(Destruir());
    }
    void Update()
    {
        transform.position += moveDirection * speed * Time.deltaTime;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            EnemyStatus enemy = other.GetComponent<EnemyStatus>();
            if (enemy != null)
            {
                enemy.TakeDamage(damage);
            }
            Destroy(gameObject);
        }
    }
    IEnumerator Destruir()
    {
        while (lifetime >= 0)
        {

            yield return new WaitForSeconds(1);
            lifetime--;
        }
        Destroy(gameObject);
    }
}
