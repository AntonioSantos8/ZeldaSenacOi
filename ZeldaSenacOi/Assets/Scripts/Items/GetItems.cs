using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetItems : MonoBehaviour
{
    bool isTouchingPlayer;
    public GameObject item;
    public GameObject itemIMG;
    public GameObject itemSobrePos;
    // Start is called before the first frame update
    void Update()
    {
        GetItem();
        if (isTouchingPlayer)
        {
            itemSobrePos.SetActive(true);
        }
        if (!isTouchingPlayer)
        {
            itemSobrePos.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isTouchingPlayer = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isTouchingPlayer = !isTouchingPlayer;
        }
    }
    void GetItem()
    {
        if (isTouchingPlayer && Input.GetKeyDown(KeyCode.R))
        {
            Items.itens.Add(item);
            Items.itensIMG.Add(itemIMG);
            Destroy(gameObject);
        }

    }
}
