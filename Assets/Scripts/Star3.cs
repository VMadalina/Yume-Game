using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star3 : MonoBehaviour
{

    public int points2;

    void OnTriggerEnter2D(Collider2D collision)//add points when collect a star
    {
        if (collision.name == "Yume2")
        {
            Level3Manager.AddPoints(points2);
            Destroy(gameObject);
        }
    }
}
