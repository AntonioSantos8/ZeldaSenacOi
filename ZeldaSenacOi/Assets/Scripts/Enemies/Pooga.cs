using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pooga : EnemyStatus
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Die();
    }
    void Die()
    {
        if (life <= 0)
        {
            Destroy(gameObject);
        }
    }
}
