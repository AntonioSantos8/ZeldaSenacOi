using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caixas : MonoBehaviour
{
    PuzzleZinho puzzle;
    // Start is called before the first frame update
    void Start()
    {
        puzzle = FindObjectOfType<PuzzleZinho>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Placa"))
        {
            puzzle.ativouIndex++;
            
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Placa"))
        {
            puzzle.ativouIndex--;

        }
    }
}
