using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ayarlar2 : MonoBehaviour
{
    public GameObject panel1;
    public GameObject panel2;

    public void Settings()
    {
        panel1.SetActive(false);
        panel2.SetActive(true);
    }
}
