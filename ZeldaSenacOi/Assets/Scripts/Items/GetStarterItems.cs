using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetStarterItems : MonoBehaviour
{
    public GameObject velocityPot;
    public GameObject velocityPotIMG;
    public GameObject sword;
    public GameObject swordIMG;
    // Start is called before the first frame update
    private void Awake()
    {
        Items.itens.Add(sword);
        Items.itensIMG.Add(swordIMG);
    }
    void Start()
    {
        Items.itens.Add(velocityPot);
        Items.itensIMG.Add(velocityPotIMG);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
