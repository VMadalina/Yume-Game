using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CameraControl : MonoBehaviour {

    public Transform player;
    public float yOffseat;

	void Update ()
    {
        transform.position = new Vector3(player.position.x, player.position.y+yOffseat , transform.position.z);
	}
}
