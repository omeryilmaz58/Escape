using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Rigidbody2D enemy2D;
    public float enemySpeed;

    [Tooltip("Karakterin duvara degip degmedigini kontrol eder.")]
    bool isGrounded;
    Transform grounCheck;
    const float GroundCheckRadius = 0.2f;
    [Tooltip("Duvarin ne oldugunu belirler")]
    public LayerMask groundLayer;
    public bool moveRight;
    public GameObject panel;
    public GameObject karakter;
    public AudioSource aSource;


    // Start is called before the first frame update
    void Start()
    {
        enemy2D = GetComponent<Rigidbody2D>();
        grounCheck = transform.Find("GroundCheck");
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(grounCheck.position, GroundCheckRadius, groundLayer);

        if (isGrounded)
            moveRight = !moveRight;

        enemy2D.velocity = (moveRight) ? new Vector2(enemySpeed, 0) : new Vector2(-enemySpeed, 0);
        transform.localScale = (moveRight) ? new Vector2(-1,1) : new Vector2(1,1);
    }
    
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
