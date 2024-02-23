using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rgb;
    Vector3 velocity;
    Vector3 position;
    public Animator animator;
    float speedAmount = 5f;
    float jumpAmount = 7f;
    float horizontalMoveSpeed;
    public AudioSource aSource;
    public float audioVolume;
    public AudioClip Jump;
    public float jumpVolume;
    public GameObject panel;
    public GameObject karakter;
    public Joystick joystick;

    
    // Start is called before the first frame update
    void Start()
    {
        position = transform.position;
        rgb = GetComponent<Rigidbody2D>();
        aSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (joystick.Horizontal > 0.5f)
        {
            horizontalMoveSpeed = 1;
        }
        else if (joystick.Horizontal < -0.5f)
        {
            horizontalMoveSpeed = -1;
        }
        else
        {
            horizontalMoveSpeed = 0;
        }

        velocity = new Vector3(horizontalMoveSpeed, 0f);
        transform.position += velocity * speedAmount * Time.deltaTime;
        animator.SetFloat("Hýz", Mathf.Abs(joystick.Horizontal));
        if (horizontalMoveSpeed == 0)
        {
            animator.SetFloat("Hýz", 0f);
        }

        if (Input.GetKey(KeyCode.Space) && !animator.GetBool("Zýplama"))
        {
            rgb.AddForce(Vector3.up * jumpAmount, ForceMode2D.Impulse);
            animator.SetBool("Zýplama", true);
            aSource.PlayOneShot(Jump, jumpVolume);
        }

        if (horizontalMoveSpeed == -1)
        {
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }

        else if(horizontalMoveSpeed == 1)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Enemy"))
        {
            panel.SetActive(true);
            karakter.SetActive(false);
        }
        if(collision.gameObject.name == "Tilemap")
        {
            animator.SetBool("Zýplama", false);
        }
        if (collision.gameObject.tag.Equals("reset"))
        {
            position.x += 0f;
            transform.position = position;
        }
        if (collision.gameObject.tag.Equals("Coin"))
        {
            aSource.Play();
            aSource.volume = audioVolume;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Tilemap")
        {
            animator.SetBool("Zýplama", true);
        }
    }
    public void AudioVolume(float vol)
    {
        audioVolume = vol;
    }
    public void JumpVolume(float vol2)
    {
        jumpVolume = vol2;
    }

    public void Zýplama()
    {
        if (!animator.GetBool("Zýplama"))
        {
            rgb.AddForce(Vector3.up * jumpAmount, ForceMode2D.Impulse);
            animator.SetBool("Zýplama", true);
            aSource.PlayOneShot(Jump, jumpVolume);
        }
    }
}
