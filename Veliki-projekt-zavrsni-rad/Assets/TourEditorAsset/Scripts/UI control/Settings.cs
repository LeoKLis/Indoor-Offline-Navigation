using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public Button settingsButton;
    //public GameObject settingsCanvas;
    public GameObject settingsS;

    static int settingsCunt = 1;

    private void Start()
    {
        //settingsCanvas.transform.localPosition = new Vector3(Screen.width, 0);
        if (settingsCunt == 0)
        {
            LeanTween.moveX(settingsS, -Screen.width * 2, 0f);
        }
        else if (settingsCunt == 1)
        {
            LeanTween.moveX(settingsS, Screen.width / 2, 0f);
        }
        else
        {
            Debug.Log("Onda ne radi");
        }
    }

    void Awake()
    {
        settingsButton.onClick.AddListener(OnClickSettings);
    }

    void OnClickSettings()
    {
        if(settingsCunt == 1)
        {
            LeanTween.moveX(settingsS, -Screen.width/2, 0.8f);
            settingsCunt--;
        }
        else if(settingsCunt == 0)
        {
            LeanTween.moveX(settingsS, Screen.width/2, 0.8f);
            settingsCunt++;
        }
        else
        {
            Debug.Log("Onda ne radi");
        }
    }
}
