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
    int timeToRevive = 2;
    // Start is called before the first frame update
    void Start()
    {
        playerMove = FindObjectOfType<PlayerMove>();
        lifeValue = playerMove.life;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerMove.life <= 0)
        {
            StartCoroutine(Reviver());
        }
        
    }
    IEnumerator Reviver()
    {
        playerBody.transform.position = spawnPoint.transform.position;
        playerBody.SetActive(false);
       painel.SetActive(true);
        yield return new WaitForSeconds(timeToRevive);
        texto.text = timeToRevive.ToString();
        painel.SetActive(false);
        playerMove.life = lifeValue;
        playerBody.SetActive(true);
    }
}
