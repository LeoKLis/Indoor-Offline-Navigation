using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TweenMove : MonoBehaviour
{
    public Button hideMenu;
    static int hideCnt = 0;

    private void Start()
    {
        Debug.Log("Start");
        if (hideCnt == 0)
        {
            LeanTween.moveY(gameObject, 0, 0f);
        }
        else if (hideCnt == 1)
        {
            LeanTween.moveY(gameObject, -135, 0f);
        }
        else
        {
            Debug.Log("Ne dela");
        }
    }

    void Awake()
    {
        hideMenu.onClick.AddListener(HideMenuClick);    
    }

    void HideMenuClick()
    {
        if(hideCnt == 0)
        {
            LeanTween.moveY(gameObject, -135, 0.5f);
            hideCnt++;
        }
        else if(hideCnt == 1)
        {
            LeanTween.moveY(gameObject, 115, 0.5f);
            hideCnt--;
        }
        else
        {
            Debug.Log("Fuk");
        }
    }

    
}
