using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIcoms : MonoBehaviour
{
    int brojo = 0;
    int srcCnt = 0;
    public RectTransform menuNav;
    public Button hideMenu;
    public Button hideSearch;
    public GameObject brojUcione;
    void Start()
    {
        brojUcione.SetActive(false);
    }

    // Update is called once per frame
    void Awake()
    {
        hideMenu.onClick.AddListener(buttonClicked);
        hideSearch.onClick.AddListener(searchClicked);
    }

    void buttonClicked()
    {
        if (brojo == 0)
        {
            menuNav.localPosition += new Vector3(0, -268, 0);
            //hideMenu.transform.localPosition += new Vector3(0, -20, 0);
            //hideMenu.image.sprite.
            brojo++;
        }
        else if (brojo == 1)
        {
            menuNav.localPosition += new Vector3(0, 268, 0);
            //hideMenu.transform.localPosition += new Vector3(0, 20, 0);
            brojo--;
        }
        else
        {
            Debug.Log("A kaj sad bokte");
        }
    }

    void searchClicked()
    {
        if(srcCnt == 0)
        {
            brojUcione.SetActive(true);
            srcCnt++;
        }
        else if(srcCnt == 1)
        {
            brojUcione.SetActive(false);
            srcCnt--;
        }
        else
        {
            Debug.Log("Ne radi");
        }
    }
}
