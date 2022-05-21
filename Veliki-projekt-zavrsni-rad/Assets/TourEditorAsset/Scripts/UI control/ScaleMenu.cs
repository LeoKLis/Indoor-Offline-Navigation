using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleMenu : MonoBehaviour
{
    public RectTransform menu;
    public RectTransform searchButton;
    public RectTransform setButton;

    //public RectTransform settingsCanvas;
    public RectTransform banner;

    public RectTransform searchBar;
    //public RectTransform settingsText;
    public RectTransform firstOption;
    void Start()
    {
        menu.sizeDelta = new Vector2(Screen.width, Screen.height/10);
        
        searchButton.localScale = new Vector2(menu.sizeDelta.x / 700, menu.sizeDelta.x / 700);
        searchButton.anchoredPosition = new Vector2(-menu.sizeDelta.x / 4, 0);

        setButton.localScale = new Vector2(menu.sizeDelta.x / 700, menu.sizeDelta.x / 700);
        setButton.anchoredPosition = new Vector2(menu.sizeDelta.x / 4, 0);

        //settingsCanvas.sizeDelta = new Vector2(Screen.width, Screen.height);

        searchBar.sizeDelta = new Vector2(Screen.width * 0.88f, Screen.height / 14.5f);
        //settingsText.position = new Vector2(searchBar.sizeDelta.x * 1.82f, settingsText.position.y);
    }
}
