using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleZinho : MonoBehaviour
{
    public int ativouIndex;
    public GameObject portao;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ativouIndex == 4)
        {
            portao.SetActive(false);
        }
    }
}
