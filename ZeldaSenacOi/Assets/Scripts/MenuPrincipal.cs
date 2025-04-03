using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public GameObject creditosPanel;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void StartGame()
    {
        SceneManager.LoadScene("Jogo Mapa");
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false; // Para o jogo no editor
#else
        Application.Quit(); // Fecha o jogo no build
#endif

        Debug.Log("Jogo encerrado");
    }

    public void CreditosAbre()
    {
        creditosPanel.SetActive(true);
    }

    public void CreditosFecha()
    {
        creditosPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}