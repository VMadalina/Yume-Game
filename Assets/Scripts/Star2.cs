using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star2 : MonoBehaviour
{

    public int points1;

    void OnTriggerEnter2D(Collider2D collision)//add points when collect a star
    {
        if (collision.name == "Yume1")
        {
            Level2Manager.AddPoints(points1);
            Destroy(gameObject);
        }
    }
}
