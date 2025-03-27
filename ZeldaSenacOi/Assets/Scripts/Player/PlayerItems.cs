using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerItems : MonoBehaviour
{
    public GameObject actualItem;
    public GameObject actualItemIMG;
    int currentInt;
    private float lastMoveX = 1;
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
        float moveY = Input.GetAxisRaw("Vertical");

        if (moveX != 0)
            lastMoveX = moveX;

        if (moveY == 0) 
            actualItem.transform.position = gameObject.transform.position + new Vector3(2 * lastMoveX, 0, 0);
        else 
            actualItem.transform.position = gameObject.transform.position + new Vector3(0, 2 * Mathf.Sign(moveY), 0);
    }
    
}

