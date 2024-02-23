using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Para : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            Skor player = collision.gameObject.GetComponent<Skor>();
            player.score += 1;
            gameObject.SetActive(false);
            
        }
    }
}
