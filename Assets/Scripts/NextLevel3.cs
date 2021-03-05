using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel3 : MonoBehaviour
{

    public GameObject nextLevelButton;

    //Use this for initialization
    void Start()
    {
        nextLevelButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if ( Level4Manager.score3 >= 230)//appear next level button when condition is true
        {
            nextLevelButton.SetActive(true);
        }
        else
            nextLevelButton.SetActive(false);
    }
}
