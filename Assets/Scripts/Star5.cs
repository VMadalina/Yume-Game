using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star5 : MonoBehaviour
{

    public int points4;

    void OnTriggerEnter2D(Collider2D collision)//add points when collect a star
    {
        if (collision.name == "Yume4")
        {
            Level5Manager.AddPoints(points4);
            Destroy(gameObject);
        }
    }
}
