using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Su : MonoBehaviour
{
    public GameObject panel;
    public GameObject karakter;
    public AudioSource aSource;

    private void OnCollisionEnter2D(Collision2D temas)
    {
        if (temas.gameObject.tag == "Player")
        {
            panel.SetActive(true);
            karakter.SetActive(false);
            aSource.Play();
        }
    }
}
