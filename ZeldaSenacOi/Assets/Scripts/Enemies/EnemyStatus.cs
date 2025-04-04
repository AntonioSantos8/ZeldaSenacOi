using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.LowLevel;

public class EnemyStatus : MonoBehaviour
{
    public int life;
    public float smooth;
    public float speed;
    public SpriteRenderer sprite;
    public float knockbackForce = 5f;
   

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamage(int damage)
    {
        life -= damage;
        StartCoroutine(FeedBack());
        
    }
    
    IEnumerator FeedBack()
    {
        sprite.color = Color.red;
        yield return new WaitForSeconds(0.25f);
        sprite.color = Color.white;
    }
}
