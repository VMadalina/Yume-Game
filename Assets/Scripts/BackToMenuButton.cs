using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class BackToMenuButton : MonoBehaviour {

   public  void LoadMainMenu ()
    {
        SceneManager.LoadScene("Menu");
    }
}
