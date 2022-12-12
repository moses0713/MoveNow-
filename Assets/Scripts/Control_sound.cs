using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Control_sound : MonoBehaviour
{

    static AudioSource asound;
    static Slider sd;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Con_Sound() {

        asound.volume = sd.value;

    }
}
