using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class FindlevelScripts : MonoBehaviour
{
    public Sprite[] ImageFace;
    public Sprite ImageBack;
    public GameObject[] images;
    public GameObject nextLevelButton;

    private bool _init = false;
    private int _matches = 10;

    void Start()
    {
        nextLevelButton.SetActive(false);
    }

    void Update()
    {
        if (!_init)
            InitializeImage();
        if (Input.GetMouseButtonUp(0))
            CheckImage();
    }

    void InitializeImage()
    {
        for (int id = 0; id < 2; id++)
        {
            for (int i = 1; i < 11; i++)
            {
                bool test = false;
                int choise = 0;
                while (!test)
                {
                    choise = Random.Range(0, images.Length);
                    test = !(images[choise].GetComponent<FindImageScript>().Initialized);
                }
                images[choise].GetComponent<FindImageScript>().ImageValue = i;
                images[choise].GetComponent<FindImageScript>().Initialized = true;
            }
        }
        foreach (GameObject c in images)
            c.GetComponent<FindImageScript>().SetUpGraphics();
        if (!_init)
            _init = true;
    }

    public Sprite GetImageBack()
    {
        return ImageBack;
    }

    public Sprite GetImageFace(int i)
    {
        return ImageFace[i - 1];
    }

    void CheckImage()
    {
        List<int> c = new List<int>();
        for (int i = 0; i < images.Length; i++)
            if (images[i].GetComponent<FindImageScript>().State == 1)
                c.Add(i);
        if (c.Count == 2)
            ImageComparison(c);
    }

    void ImageComparison(List<int> c)
    {
        FindImageScript.DoNot = true;
        int x = 0;
        if (images[c[0]].GetComponent<FindImageScript>().ImageValue == images[c[1]].GetComponent<FindImageScript>().ImageValue)
        {
            x = 2;
            _matches--;
            if (_matches == 0)
                nextLevelButton.SetActive(true);
        }
        for (int i = 0; i < c.Count; i++)
        {
            images[c[i]].GetComponent<FindImageScript>().State = x;
            images[c[i]].GetComponent<FindImageScript>().FalseCheck();
        }
    }
}

