using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButon : MonoBehaviour
{
    public GameObject canvas;
    public GameObject canvas2;

    public void AnaMenu()
    {
        canvas.SetActive(true);
        canvas2.SetActive(false);
    }
}
