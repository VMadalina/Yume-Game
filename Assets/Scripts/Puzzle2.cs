using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle2 : MonoBehaviour
{
    public int points;

    public string pieceStatut = "idle";
    public Transform edgeParticles;
    public KeyCode placePiece;
    //public KeyCode returnToScroll;
    public string checkPlace;
    public float yDiff;
    public Vector2 scrollPos;
    
    // Update is called once per frame
    void Update()
    {
        ScrollControl();

        if (pieceStatut == "pickup")
        {
            Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 objectPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = objectPosition;
        }
        if (Input.GetKeyDown(placePiece))
        {
            checkPlace = "yes";
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if ((col.gameObject.name == gameObject.name) && (checkPlace == "yes"))//put piece in the right place
        {
            col.GetComponent<BoxCollider2D>().enabled = false;
            GetComponent<BoxCollider2D>().enabled = false;
            GetComponent<Renderer>().sortingOrder = 0;
            transform.position = col.gameObject.transform.position;
            pieceStatut = "block";
            Instantiate(edgeParticles, col.gameObject.transform.position, edgeParticles.rotation);
            checkPlace = "no";
            ScorePuzzle2.AddPoints(points);
        }

        if ((col.gameObject.name != gameObject.name) && (checkPlace == "yes"))
        {
            checkPlace = "no";
        }
    }

    void OnMouseDown()//pick up piece command
    {
        pieceStatut = "pickup";
        checkPlace = "no";
        GetComponent<Renderer>().sortingOrder = 1;
        scrollPos = transform.position;
    }

    void ScrollControl()
    {
        if ((Input.GetAxis("Mouse ScrollWheel") > 0) && (pieceStatut != "block")) //scroll up
        {
            transform.position = new Vector2(-9.70f, transform.position.y - 3.0f);
            yDiff -= 3.0f;
        }

        if ((Input.GetAxis("Mouse ScrollWheel") < 0) && (pieceStatut != "block")) //scroll down
        {
            transform.position = new Vector2(-9.70f, transform.position.y + 3.0f);
            yDiff += 3.0f;
        }
    }
}
