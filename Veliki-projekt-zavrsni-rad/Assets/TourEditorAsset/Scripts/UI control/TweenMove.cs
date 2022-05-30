using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TweenMove : MonoBehaviour
{
    public Button hideMenu;
    public Button hideMap;
    public RectTransform menuAll;
    public GameObject minimap;
    static int hideCnt = 0;
    static bool mapHid;

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

        if (mapHid) {
            minimap.SetActive(false);
        }
        else
        {
            minimap.SetActive(true);
        }
    }

    void Awake()
    {
        hideMenu.onClick.AddListener(HideMenuClick);
        hideMap.onClick.AddListener(HideMap);
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

    void HideMap()
    {
        if (!mapHid)
        {
            minimap.SetActive(false);
            mapHid = true;
        }
        else
        {
            minimap.SetActive(true);
            mapHid = false;
        }
    }
    
}
