using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSetting : MonoBehaviour {

    public Slider Volume;
    public AudioSource music;

    void Update()
    {
        music.volume = Volume.value;
    }
}
