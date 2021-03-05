using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour {
    public Level3Manager  rs;
	// Use this for initialization
	void Start ()
    {
        rs = FindObjectOfType<Level3Manager >();
	}

    void OnTriggerEnter2D( Collider2D col)//reset level when touch the spikes
    {
        if(col.name =="Yume2")
        {
            rs.ResetLevel();
        }
    }
}
