using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClickSFX : MonoBehaviour
{
    public AudioSource source;
    public AudioClip buttonsfx;
    public void Click()
    {
        source.PlayOneShot(buttonsfx, 2);
    }
}
