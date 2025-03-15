using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerItems : MonoBehaviour
{
    public GameObject[] itens;
    public GameObject actualItem;
    int currentInt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            ChangeItem();
        }
        actualItem.transform.position = gameObject.transform.position + new Vector3(2, 0, 0);
    }
    void ChangeItem()
    {
        actualItem = itens[currentInt];
        currentInt++;
        if(currentInt >= itens.Length)
        {
            currentInt = 0;
        }
        
    }
}
