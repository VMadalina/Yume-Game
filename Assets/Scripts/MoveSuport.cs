using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSuport : MonoBehaviour {
    private Vector3 posA;
    private Vector3 posB;
    private Vector3 nextPos;

    [SerializeField]
    private float speed;
    [SerializeField ]
    private Transform ct;  //ct=ChildTransform
    [SerializeField ]
    private Transform transformB;

	// Use this for initialization
	void Start ()
    {
        posA = ct.localPosition;//initial position
        posB = transformB.localPosition; //second position
        nextPos = posB;
	}
	
	// Update is called once per frame
	void Update ()
    {
        Move();
	}

    private void Move()
    {
        ct.localPosition = Vector3.MoveTowards(ct.localPosition, nextPos, speed * Time.deltaTime);

        if(Vector3 .Distance (ct.localPosition , nextPos )<=0.1)
        {
            ChangeDirection();
        }
    }

    private void ChangeDirection()
    {
        if (nextPos != posA)
            nextPos = posA;
        else
            nextPos = posB;
    }

   private void OnCollisionEnter2D(Collision2D col)//change layer for collision
   {
        if (col.gameObject.tag == "Player")
     {
            col.gameObject.layer = 9;
            col.transform.SetParent(ct);
        }
  }
   private void OnCollisionExit2D(Collision2D other)//back to initial layer
   {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.layer = 8;
            other.transform.SetParent(null);
       }
   }
}
