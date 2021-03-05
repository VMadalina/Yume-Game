using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepSoundInGame : MonoBehaviour {

    void Awake()
    {
        DontDestroyOnLoad(transform .gameObject );
    }

}
