using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes2 : MonoBehaviour
{
    public Level5Manager rl;
    // Use this for initialization
    void Start()
    {
        rl = FindObjectOfType<Level5Manager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col) //reset level when touch the spikes
    {
        if (col.name == "Yume4") 
        {
            rl.ResetLevel();
        }
    }
}
