using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPause : MonoBehaviour
{
    bool isPaused = false;
    public GameObject menuPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Pause()
    {
        menuPanel.SetActive(true);
        Time.timeScale = 0f; 
        isPaused = true;
    }
    void UnPause()
    {
        menuPanel.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
    public void BackToMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
                UnPause();
            else
                Pause();
        }
    }
}
