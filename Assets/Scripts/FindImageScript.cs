using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class FindImageScript : MonoBehaviour
{
    public static bool DoNot = false;

    [SerializeField]
    private int _state;
    [SerializeField]
    private int _ImageValue;
    [SerializeField]
    private bool _initialized = false;

    private Sprite _ImageBack;
    private Sprite _ImageFace;

    private GameObject _manager;

    void Start()
    {
        _state = 1;
        _manager = GameObject.FindGameObjectWithTag("Manager");
    }

    public void SetUpGraphics()
    {
        _ImageBack = _manager.GetComponent<FindlevelScripts>().GetImageBack();
        _ImageFace = _manager.GetComponent<FindlevelScripts>().GetImageFace(_ImageValue);

        FlipImage();
    }

    public void FlipImage()
    {
        if (_state == 0)
            _state = 1;
        else if (_state == 1)
            _state = 0;
    
        if (_state == 0 && !DoNot)
            GetComponent<Image>().sprite = _ImageBack;
        else if (_state == 1 && !DoNot)
            GetComponent<Image>().sprite = _ImageFace;
    }
    public int ImageValue
    {
        get { return _ImageValue; }
        set { _ImageValue = value; }
    }

    public int State
    {
        get { return _state; }
        set { _state = value; }
    }

    public bool Initialized
    {
        get { return _initialized; }
        set { _initialized = value; }
    }

    public void FalseCheck()
    {
        StartCoroutine(Pause());
    }

    IEnumerator Pause()
    {
        yield return new WaitForSeconds(1);
        if(_state ==0)
            GetComponent <Image>().sprite= _ImageBack;
        else if(_state==1)
            GetComponent <Image>().sprite = _ImageFace;
        DoNot = false;
    }

}
