using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelButon : MonoBehaviour
{
    public GameObject panel;
    public GameObject karakter;

    public void DevamButon()
    {
        panel.SetActive(false);
        karakter.SetActive(true);
    }
}
