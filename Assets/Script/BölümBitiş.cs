using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BölümBitiş : MonoBehaviour
{
    
    public void SonrakiLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void AnaMenü()
    {
        SceneManager.LoadScene(0);
    }
}
