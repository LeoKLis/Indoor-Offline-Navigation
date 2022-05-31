using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SearchField : MonoBehaviour
{
    public RectTransform searchMenu;
    public Button hideSearch;
    public GameObject tekst;
    Text tekstNav;
    static string lastText;
    static int srcCnt = 0;

    private void Start()
    {
        tekst = GameObject.FindGameObjectWithTag("tekst");
        tekstNav = tekst.GetComponent<Text>();
        gameObject.GetComponent<InputField>().text = lastText;
                
        if (srcCnt == 0)
        {
            LeanTween.moveY(gameObject, Screen.height + searchMenu.sizeDelta.y / 2, 0f);
        }
        else if (srcCnt == 1)
        {
            LeanTween.moveY(gameObject, Screen.height * 0.85f, 0f);
        }
        else
        {
            Debug.Log("Ne radi");
        }
    }

    private void Update()
    {
        lastText = tekstNav.text;

        if (tekstNav.text == "kendrick")
        {
            gameObject.GetComponent<AudioSource>().Play();
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
            LeanTween.moveY(gameObject, Screen.height * 0.85f, 0.5f);
            srcCnt++;
        }
        else if (srcCnt == 1)
        {
            LeanTween.moveY(gameObject, Screen.height + searchMenu.sizeDelta.y/2, 0.5f);
            srcCnt--;
        }
        else
        {
            Debug.Log("Ne radi");
        }
    }
}
