using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.LowLevel;

public class EnemyStatus : MonoBehaviour
{
    public int life;
    public float smooth;
    public float speed;
    public GameObject objToSurge;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
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
        objToSurge.SetActive(true);
        yield return new WaitForSeconds(0.25f);
        objToSurge.SetActive(false);
    }
}
