using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnaMenu : MonoBehaviour
{
    public GameObject canvas;
    public GameObject canvas2;
    
    public void PlayGame()
    {
        canvas.SetActive(false);
        canvas2.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("AnaMenu");
    }
}
