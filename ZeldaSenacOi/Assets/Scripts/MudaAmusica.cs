using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MudaAmusica : MonoBehaviour
{
    public AudioClip newMusic; 

    void Start()
    {
        Music musicManager = FindObjectOfType<Music>();
        if (musicManager != null)
        {
            musicManager.ChangeMusic(newMusic);
        }
    }
    
}
