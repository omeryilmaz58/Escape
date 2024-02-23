using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ayarlar : MonoBehaviour
{
    public GameObject panel1;
    public GameObject panel2;
    public GameObject karakter;

    public void Settings()
    {
        panel1.SetActive(false);
        panel2.SetActive(true);
        karakter.SetActive(false);
    }
    public void BackButton()
    {
        panel1.SetActive(true);
        panel2.SetActive(false);
        karakter.SetActive(false);
    }
}
