using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes1 : MonoBehaviour
{
    public Level4Manager r;
    // Use this for initialization
    void Start()
    {
        r = FindObjectOfType<Level4Manager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col) //reset level when touch the spikes
    {
        if (col.name == "Yume3" )
        {
            r.ResetLevel();
        }
    }
}
