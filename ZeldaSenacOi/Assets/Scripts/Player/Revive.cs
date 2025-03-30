using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Revive : MonoBehaviour

{
    public GameObject spawnPoint;
    public GameObject playerBody;
    PlayerMove playerMove;
    int lifeValue;
    public TMP_Text texto;
    public GameObject painel;
    float timeToRevive = 3f;
    bool isReviving = false;
    bool podeChamar;
   
    // Start is called before the first frame update
    void Start()
    {
        podeChamar = true;
        playerMove = FindObjectOfType<PlayerMove>();
        lifeValue = playerMove.life;
    }

    // Update is called once per frame
    void Update()
    {
        

        if (playerMove.life <= 0 && !isReviving)
        {
            StartCoroutine(Reviver());
            podeChamar = false;
        }

    }
    IEnumerator Reviver()
    {
       
        if (!podeChamar) yield break;
        playerBody.transform.position = spawnPoint.transform.position;
        playerBody.SetActive(false);
        painel.SetActive(true);
        float tempoAtual = timeToRevive;
        while (tempoAtual > 0)
        {
            texto.text = "VOCE MORREU, renascendo em: " + tempoAtual.ToString();
            yield return new WaitForSeconds(1);
            tempoAtual--;
        }
        painel.SetActive(false);
        playerMove.life = lifeValue;
        playerBody.SetActive(true);
        podeChamar = true;
    }
}
