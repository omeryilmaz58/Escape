using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SeviyelerYöneticisi : MonoBehaviour
{
    public List<Button> levelButton;

    private void Start()
    {
        int saveIndex = PlayerPrefs.GetInt("SaveIndex");

        for (int i=0; i < levelButton.Count; i++)
        {
            if (i<=saveIndex)
            {
                levelButton[i].interactable = true;
            }
            else
            {
                levelButton[i].interactable = false;
            }
        }
    }

}
