using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleMenu : MonoBehaviour
{
    public RectTransform menu;
    public RectTransform searchButton;
    public RectTransform setButton;
    public RectTransform mapButton;

    public RectTransform searchBar;
    void Start()
    {
        menu.sizeDelta = new Vector2(Screen.width, Screen.height/10);
        
        searchButton.sizeDelta = new Vector2(menu.sizeDelta.y / 1.8f, menu.sizeDelta.y / 1.8f);
        searchButton.anchoredPosition = new Vector2(-menu.sizeDelta.x / 4, 0);

        setButton.sizeDelta = new Vector2(menu.sizeDelta.y / 1.8f, menu.sizeDelta.y / 1.8f);
        setButton.anchoredPosition = new Vector2(menu.sizeDelta.x / 4, 0);

        mapButton.sizeDelta = new Vector2(menu.sizeDelta.y / 1.8f, menu.sizeDelta.y / 1.8f);
        mapButton.anchoredPosition = new Vector2(0, 0);

        //settingsCanvas.sizeDelta = new Vector2(Screen.width, Screen.height);

        searchBar.sizeDelta = new Vector2(Screen.width * 0.88f, Screen.height / 14.5f);
        //settingsText.position = new Vector2(searchBar.sizeDelta.x * 1.82f, settingsText.position.y);
    }
}
