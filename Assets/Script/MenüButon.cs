using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenüButon : MonoBehaviour
{


    public GameObject panel;
    public GameObject karakter;

    public void MenuButon() {

        panel.SetActive(true);
        karakter.SetActive(false);

    }

    
}
