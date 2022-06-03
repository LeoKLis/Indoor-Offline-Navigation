using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    static bool dark;
    public Button darkMode;
    public Image menu;
    public Image buttonHide;
    public Image searchField;
    public Text placeholder;
    public Text label;

    public Material gumbBoja;

    private void Start()
    {
        if (dark)
        {
            menu.color = new Color32(28, 28, 28, 255);
            buttonHide.color = new Color32(28, 28, 28, 255);
            searchField.color = new Color32(28, 28, 28, 255);
            placeholder.color = new Color32(200, 200, 200, 255);
            label.color = new Color32(200, 200, 200, 255);
            gumbBoja.color = new Color32(9, 21, 34, 128);
        }
        else
        {
            menu.color = new Color32(255, 255, 255, 255);
            buttonHide.color = new Color32(255, 255, 255, 255);
            searchField.color = new Color32(255, 255, 255, 255);
            placeholder.color = new Color32(50, 50, 50, 128);
            label.color = new Color32(50, 50, 50, 128);
            gumbBoja.color = new Color32(37, 125, 226, 128);
        }
    }

    void Awake()
    {
        darkMode.onClick.AddListener(delegate { ToggleValueChanged(); });
    }

    void ToggleValueChanged()
    {
        if (!dark)
        {
            menu.color = new Color32(28, 28, 28, 255);
            buttonHide.color = new Color32(28, 28, 28, 255);
            searchField.color = new Color32(40, 40, 40, 255);
            placeholder.color = new Color32(200, 200, 200, 255);
            label.color = new Color32(200, 200, 200, 255);
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
            gumbBoja.color = new Color32(37, 125, 226, 128);
            dark = false;
        }
    }
}
