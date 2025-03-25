using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerItems : MonoBehaviour
{
    public GameObject actualItem;
    public GameObject actualItemIMG;
    int currentInt;
    // Start is called before the first frame update
    void Start()
    {
        actualItem = Items.itens[0];
        currentInt = 0;
        actualItemIMG = Items.itensIMG[0];
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            ChangeItem();
        }
        if(actualItem != null)
            Flip();

    }
    public void ChangeItem()
    {
        if(actualItem && actualItemIMG != null)
        {
            actualItem.SetActive(false);
            actualItemIMG.SetActive(false);
        }
        currentInt++;
        if(currentInt >= Items.itens.Count)
        {
            currentInt = 0;
        }

        actualItem = Items.itens[currentInt];
        actualItemIMG = Items.itensIMG[currentInt];
        actualItem.SetActive(true);
        actualItemIMG.SetActive(true);
    }
    void Flip()
    {
        float moveX = Input.GetAxisRaw("Horizontal");

        if (moveX > 0) 
        {
            actualItem.transform.position = gameObject.transform.position + new Vector3(2, 0, 0);
        }
        else if (moveX < 0) 
        {
            actualItem.transform.position = gameObject.transform.position + new Vector3(-2, 0, 0);
        }
    }
}

