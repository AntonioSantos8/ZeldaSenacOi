using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public GameObject objetoPraTirar;
    public GameObject newSpawnPoint;
    Revive revive;
    // Start is called before the first frame update
    void Start()
    {
        revive = FindObjectOfType<Revive>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            revive.spawnPoint = newSpawnPoint;
        }
    }
}
