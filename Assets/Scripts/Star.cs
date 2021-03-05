using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour {

    public int points;

    void OnTriggerEnter2D(Collider2D collision)//add points when collect a star
    {
        if(collision .name=="Yume")
        {
            LevelManager.AddPoints(points);
            Destroy(gameObject);
        }
    }
}
