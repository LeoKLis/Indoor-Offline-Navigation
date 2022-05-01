using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SearchField : MonoBehaviour
{
    public Button hideSearch;
    static int srcCnt = 0;

    private void Start()
    {
        if (srcCnt == 0)
        {
            LeanTween.moveY(gameObject, 3500, 0f);
        }
        else if (srcCnt == 1)
        {
            LeanTween.moveY(gameObject, 2600, 0f);
        }
        else
        {
            Debug.Log("Ne radi");
        }
    }

    void Awake()
    {
        hideSearch.onClick.AddListener(SearchClicked);
    }

    void SearchClicked()
    {
        if (srcCnt == 0)
        {
            LeanTween.moveY(gameObject, 2600, 0.5f);
            srcCnt++;
        }
        else if (srcCnt == 1)
        {
            LeanTween.moveY(gameObject, 3500, 0.5f);
            srcCnt--;
        }
        else
        {
            Debug.Log("Ne radi");
        }
    }
}
