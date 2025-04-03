using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifePot : MonoBehaviour
{
    public GameObject objetoParaRemove;
    public GameObject IMGParaRemove;
    PlayerStatus status;
    PlayerItems items;
    int fatorDeCura = 1;
    // Start is called before the first frame update
    void Start()
    {
        status = GetComponent<PlayerStatus>();
        items = GetComponent<PlayerItems>();
    }

    // Update is called once per frame
    void Update()
    {
        if (items.actualItem == objetoParaRemove && items.actualItemIMG == IMGParaRemove && Input.GetKeyDown(KeyCode.R))
        {
            Cura();
        }
    }
    void Cura()
    {
        Items.itens.Remove(objetoParaRemove);
        Items.itensIMG.Remove(IMGParaRemove);
        objetoParaRemove.SetActive(false);
        IMGParaRemove.SetActive(false);
        items.ChangeItem();
        status.life += fatorDeCura;
    }
}
