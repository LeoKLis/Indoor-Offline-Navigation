using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TweenMove : MonoBehaviour
{
    public Button hideMenu;
    int hideCnt = 0;
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
            LeanTween.moveY(gameObject, 135, 0.5f);
            hideCnt--;
        }
        else
        {
            Debug.Log("Fuk");
        }
    }

    
}
