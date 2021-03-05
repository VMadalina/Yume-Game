using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class RestartButton : MonoBehaviour {

    public void RestartLevel ()//for level 4 Bonus
    {
        SceneManager.LoadScene("Level 4 Bonus");
    }
}
