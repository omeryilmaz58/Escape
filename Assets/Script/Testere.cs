using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testere : MonoBehaviour
{
    public GameObject panel;
    public GameObject karakter;
    public AudioSource aSource;

    private void OnCollisionEnter2D(Collision2D temas)
    {
        if(temas.gameObject.tag == "Player")
        {
            panel.SetActive(true);
            karakter.SetActive(false);
            aSource.Play();
        }
    }

    void Update()
    {
        transform.Rotate(0, 0, 6);    
    }
}
