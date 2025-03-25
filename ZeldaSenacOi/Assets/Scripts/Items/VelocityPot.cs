using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityPot : MonoBehaviour
{
    public GameObject objetoParaRemove;
    public GameObject IMGParaRemove;
    PlayerStatus status;
    PlayerItems items;
    // Start is called before the first frame update
    void Start()
    {
        status = GetComponent<PlayerStatus>();
        items = GetComponent<PlayerItems>();
    }

    // Update is called once per frame
    void Update()
    {
        if(items.actualItem == objetoParaRemove && items.actualItemIMG == IMGParaRemove && Input.GetKeyDown(KeyCode.R))
        {
            UsePot();
        }
        
    }
    public void UsePot()
    {
        StartCoroutine(GetVelocity());
        objetoParaRemove.SetActive(false);
        IMGParaRemove.SetActive(false);
        items.ChangeItem();
    }
    IEnumerator GetVelocity()
    {
        status.moveSpeed *= 2f;
        Items.itens.Remove(objetoParaRemove);
        Items.itensIMG.Remove(IMGParaRemove);
        yield return new WaitForSeconds(5);
        status.moveSpeed = 10;
    }
}
