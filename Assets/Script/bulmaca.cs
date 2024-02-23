using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulmaca : MonoBehaviour
{
    public GameObject grid;
    public GameObject buton;
    public GameObject su;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            grid.SetActive(true);
            buton.SetActive(false);
            su.SetActive(false);
        }
    }
}
