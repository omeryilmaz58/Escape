using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SeviyeBitirme : MonoBehaviour
{
    public int buildIndex = 0;
    public int saveIndex;

    private void Start()
    {
        buildIndex = SceneManager.GetActiveScene().buildIndex;
        Text levelText = GameObject.Find("LevelText").GetComponent<Text>();
        levelText.text = "Level_" + buildIndex.ToString();
        saveIndex = PlayerPrefs.GetInt("SaveIndex");

    }

    public void NextLevel()
    {
        
        if (buildIndex > saveIndex)
        {
            PlayerPrefs.SetInt("SaveIndex", buildIndex);
        }
        
    }
    public void Sifirla()
    {
        PlayerPrefs.SetInt("SaveIndex", 0);
    }
}
