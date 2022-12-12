using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioControl : MonoBehaviour
{
    // Start is called before the first frame update

    public Slider slider;
    public Toggle toggle;
    public AudioSource BGmusic;


    public void ControlAudio()
    {
        if(toggle.isOn)
        {
            BGmusic.gameObject.SetActive(true);
            Volume();
        }

        else
        {
            BGmusic.gameObject.SetActive(false);
        }
    }

    public void Volume()
    {
        BGmusic.volume = slider.value;
    }
}
