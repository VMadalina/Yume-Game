using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SelectLevelController : MonoBehaviour
{
    public Button level1BonusButton, level2Button, level2BonusButton, level3Button, level3BonusButton,level4Button, level4BonusButton,level5Button;
    int levelPassed;

    void Start()
    {
        levelPassed=PlayerPrefs.GetInt ("LevelPassed");
        level1BonusButton.interactable = false;
        level2Button.interactable = false;
        level2BonusButton.interactable = false;
        level3Button.interactable = false;
        level3BonusButton.interactable = false;
        level4Button.interactable = false;
        level4BonusButton.interactable = false;
        level5Button.interactable = false;

        switch(levelPassed ) //activate button for the level 
        {
            case 1:
                level1BonusButton.interactable = true;
                break;

            case 2:
                level1BonusButton.interactable = true;
                level2Button.interactable = true;
                break;

            case 3:
                level1BonusButton.interactable = true;
                level2Button.interactable = true;
                level2BonusButton.interactable = true ;
                break;

            case 4:
                level1BonusButton.interactable = true;
                level2Button.interactable = true;
                level2BonusButton.interactable = true;
                level3Button.interactable = true;
                break;

            case 5:
                level1BonusButton.interactable = true;
                level2Button.interactable = true;
                level2BonusButton.interactable = true;
                level3Button.interactable = true;
                level3BonusButton.interactable = true;
                break;

            case 6:
                level1BonusButton.interactable = true;
                level2Button.interactable = true;
                level2BonusButton.interactable = true;
                level3Button.interactable = true;
                level3BonusButton.interactable = true;
                level4Button.interactable = true;
                break;

            case 7:
                level1BonusButton.interactable = true;
                level2Button.interactable = true;
                level2BonusButton.interactable = true;
                level3Button.interactable = true;
                level3BonusButton.interactable = true;
                level4Button.interactable = true;
                level4BonusButton.interactable = true;
                break;

            case 8:
                level1BonusButton.interactable = true;
                level2Button.interactable = true;
                level2BonusButton.interactable = true;
                level3Button.interactable = true;
                level3BonusButton.interactable = true;
                level4Button.interactable = true;
                level4BonusButton.interactable = true;
                level5Button.interactable = true;
                break;
        }
    }

    public void LevelToLoad(int level)
    {
        SceneManager.LoadScene(level);
    }

    public void ResetPlayerPerfs()
    {
        level1BonusButton.interactable = false;
        level2Button.interactable = false;
        level2BonusButton.interactable = false;
        level3Button.interactable = false;
        level3BonusButton.interactable = false;
        level4Button.interactable = false;
        level4BonusButton.interactable = false;
        level5Button.interactable = false;
        PlayerPrefs.DeleteAll();
    }
}
