using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonToOpenDoor : MonoBehaviour
{
    bool canInteract;
    public GameObject doorToOpen;
    public GameObject itemSobrePos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canInteract && Input.GetKeyDown(KeyCode.R))
        {
            Destroy(doorToOpen);
            Destroy(gameObject);
        }
        if (canInteract)
        {
            itemSobrePos.SetActive(true);
        }
        if (!canInteract)
        {
            itemSobrePos.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            canInteract = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            canInteract = false;
        }
    }
}
