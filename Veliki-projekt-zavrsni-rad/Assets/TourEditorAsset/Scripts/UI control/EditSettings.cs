using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EditSettings : MonoBehaviour
{
    static bool dark;
    public Toggle darkMode;
    public Image menu;
    public Image buttonHide;
    public Image searchField;
    public Text placeholder;
    public Text label;

    public Image settingsCan;
    public Text namePos;
    public Text darkModeLabel;

    public Material gumbBoja;

    // Update is called once per frame

    private void Start()
    {       
        if (dark)
        {
            darkMode.isOn = true;
            menu.color = new Color32(28, 28, 28, 255);
            buttonHide.color = new Color32(28, 28, 28, 255);
            searchField.color = new Color32(28, 28, 28, 255);
            placeholder.color = new Color32(200, 200, 200, 255);
            label.color = new Color32(200, 200, 200, 255);
            settingsCan.color = new Color32(50, 50, 50, 255);
            namePos.color = new Color32(200, 200, 200, 255);
            darkModeLabel.color = new Color32(200, 200, 200, 255);
            gumbBoja.color = new Color32(9, 21, 34, 128);
        }
        else
        {
            darkMode.isOn = false;
            menu.color = new Color32(255, 255, 255, 255);
            buttonHide.color = new Color32(255, 255, 255, 255);
            searchField.color = new Color32(255, 255, 255, 255);
            placeholder.color = new Color32(50, 50, 50, 128);
            label.color = new Color32(50, 50, 50, 128);
            settingsCan.color = new Color32(197, 197, 197, 255);
            namePos.color = new Color32(50, 50, 50, 128);
            darkModeLabel.color = new Color32(50, 50, 50, 128);
            gumbBoja.color = new Color32(37, 125, 226, 128);
        }
    }
    void Awake()
    {
        darkMode.onValueChanged.AddListener(delegate { ToggleValueChanged(darkMode); });
    }

    void ToggleValueChanged(Toggle change)
    {
        if (darkMode.isOn || !dark)
        {
            menu.color = new Color32(28, 28, 28, 255);
            buttonHide.color = new Color32(28, 28, 28, 255);
            searchField.color = new Color32(40, 40, 40, 255);
            placeholder.color = new Color32(200, 200, 200, 255);
            label.color = new Color32(200, 200, 200, 255);
            settingsCan.color = new Color32(50, 50, 50, 255);
            namePos.color = new Color32(200, 200, 200, 255);
            darkModeLabel.color = new Color32(200, 200, 200, 255);
            gumbBoja.color = new Color32(9, 21, 34, 128);

            dark = true;
        }
        else
        {
            menu.color = new Color32(255, 255, 255, 255);
            buttonHide.color = new Color32(255, 255, 255, 255);
            searchField.color = new Color32(255, 255, 255, 255);
            placeholder.color = new Color32(50, 50, 50, 128);
            label.color = new Color32(50, 50, 50, 128);
            settingsCan.color = new Color32(197, 197, 197, 255);
            namePos.color = new Color32(50, 50, 50, 128);
            darkModeLabel.color = new Color32(50, 50, 50, 128);
            gumbBoja.color = new Color32(37, 125, 226, 128);

            dark = false;
        }
    }
}
