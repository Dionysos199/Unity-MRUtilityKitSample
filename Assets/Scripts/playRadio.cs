using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playRadio : MonoBehaviour
{
    public void onPlayBtnPressed()
    {
        GetComponent<AudioSource>().Play();
    }
}
