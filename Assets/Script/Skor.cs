using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Skor : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI skorText;

    void Start()
    {
        score = PlayerPrefs.GetInt("skor");
    }
    

    void Update()
    {
        skorText.text = "Skor :" + " " + score.ToString();
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Finish"))
        {
            PlayerPrefs.SetInt("skor", score);
        }
    }

    public void Sifirla()
    {
        PlayerPrefs.SetInt("skor", 0);
    }
}
