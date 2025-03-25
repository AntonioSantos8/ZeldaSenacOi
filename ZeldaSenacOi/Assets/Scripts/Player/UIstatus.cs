using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIstatus : MonoBehaviour
{
    public TMP_Text money;
    public Image[] hearts;
    PlayerStatus status;
    // Start is called before the first frame update
    void Start()
    {
        status = FindObjectOfType<PlayerStatus>();
    }

    // Update is called once per frame
    void Update()
    {
        money.text = "Money: " + PlayerMoney.money.ToString();
        if(status.life == 2)
        hearts[0].color = Color.grey;
        if(status.life == 1)
        {
            hearts[0].color = Color.grey;
            hearts[1].color = Color.grey;
        }
    }
}
