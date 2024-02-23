using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GürzSes : MonoBehaviour
{

    public AudioSource aSource;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            aSource.Play();
        }
    }

}
