using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star4 : MonoBehaviour
{

    public int points3;

    void OnTriggerEnter2D(Collider2D collision) //add points when collect a star
    {
        if (collision.name == "Yume3")
        {
            Level4Manager.AddPoints(points3);
            Destroy(gameObject);
        }
    }
}
