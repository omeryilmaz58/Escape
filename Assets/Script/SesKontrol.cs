using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SesKontrol : MonoBehaviour
{
    public AudioSource aSource;
    public float musicVolume;

    void Start()
    {
        aSource = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        aSource.volume = musicVolume;
    }

    public void Volume(float vol)
    {
        musicVolume = vol;
    }
}
