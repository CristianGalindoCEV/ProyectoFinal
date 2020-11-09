using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasMainMenu : MonoBehaviour
{

    public GameObject menu;


    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void PulsaOpciones()
    {
        menu.SetActive (true);
    }
    public void PulsaExit()
    {
        Application.Quit();
    }
    public void PulsaPlay()
    {
        SceneManager.LoadScene("MainScene");
    }
}
