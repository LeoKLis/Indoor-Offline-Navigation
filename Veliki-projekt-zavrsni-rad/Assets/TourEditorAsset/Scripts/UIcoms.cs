using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIcoms : MonoBehaviour
{
    int brojo = 0;
    public RectTransform menuNav;
    public Button hideMenu;
    void Start()
    {

    }

    // Update is called once per frame
    void Awake()
    {
        hideMenu.onClick.AddListener(buttonClicked);
    }

    void buttonClicked()
    {
        if (brojo == 0)
        {
            menuNav.localPosition += new Vector3(0, -66, 0);
            hideMenu.transform.localPosition += new Vector3(0, -66, 0);
            brojo++;
        }
        else if (brojo == 1)
        {
            menuNav.localPosition += new Vector3(0, 66, 0);
            hideMenu.transform.localPosition += new Vector3(0, 66, 0);
            brojo--;
        }
        else
        {
            Debug.Log("A kaj sad bokte");
        }
    }
}
