using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TweenMove : MonoBehaviour
{
    public Button hideMenu;
    public RectTransform menuAll;
    static int hideCnt = 0;

    private void Start()
    {
        if (hideCnt == 0)
        {
            LeanTween.moveY(gameObject, 0, 0f);
        }
        else if (hideCnt == 1)
        {
            LeanTween.moveY(gameObject, -menuAll.rect.height, 0f);
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
            LeanTween.moveY(gameObject, -menuAll.rect.height, 0.5f);
            hideCnt++;
        }
        else if(hideCnt == 1)
        {
            LeanTween.moveY(gameObject, 0, 0.5f);
            hideCnt--;
        }
        else
        {
            Debug.Log("Fuk");
        }
    }

    
}
