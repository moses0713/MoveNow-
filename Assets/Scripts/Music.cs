using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : AudioControl
{
    public AudioSource newBGmusic;

    public void newVolume()
    {
        newBGmusic.volume = BGmusic.volume;
    }
}
