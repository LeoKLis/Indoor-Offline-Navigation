using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScaleSettings : MonoBehaviour
{
    public RectTransform settingsMenu;
    public RectTransform textP;
    public RectTransform container;
    public RectTransform darkMode;
    public RectTransform toggleBit;
    public RectTransform cMark;

    public Button moveSettings;
    void Start()
    {
        settingsMenu.sizeDelta = new Vector2(Screen.width, Screen.height);
        settingsMenu.position = new Vector2(Screen.width, Screen.height / 2);
        LeanTween.moveX(settingsMenu, -Screen.width, 0f);

        textP.sizeDelta = new Vector2(Screen.width * 0.85f, Screen.height / 12f);
        textP.position = new Vector2(settingsMenu.position.x, settingsMenu.position.y * 1.8f);

        container.sizeDelta = new Vector2(Screen.width, Screen.height * 0.8f);
        container.position = new Vector2(settingsMenu.position.x, settingsMenu.position.y * 0.8f);

        darkMode.sizeDelta = new Vector2(Screen.width * 0.7f, Screen.height / 26f);
        darkMode.position = new Vector2(container.position.x * 1.02f, container.position.y * 1.9f);

        toggleBit.sizeDelta = new Vector2(darkMode.sizeDelta.x/18, darkMode.sizeDelta.x/18);
        cMark.sizeDelta = new Vector2(toggleBit.sizeDelta.x * 0.8f, toggleBit.sizeDelta.x * 0.8f);
    }

    private void Awake()
    {
        moveSettings.onClick.AddListener(MoveSettings);
    }
    
    private void MoveSettings()
    {
        if(settingsMenu.position.x < 0)
        {
            LeanTween.moveX(settingsMenu, 0, 0.5f);
        }
        else if(settingsMenu.position.x >= 0)
        {
            LeanTween.moveX(settingsMenu, -Screen.width, 0.5f);
        }
        else
        {
            Debug.Log("Ne radi");
        }
    }
}
