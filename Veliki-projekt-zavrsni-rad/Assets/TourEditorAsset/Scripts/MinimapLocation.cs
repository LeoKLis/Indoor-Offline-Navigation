using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MinimapLocation : MonoBehaviour
{
    public RectTransform location;
    public RectTransform canv;
    static bool isLarge;
    void Start()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (isLarge)
        {
            canv.LeanScale(new Vector3(2, 2), 0f);
            canv.LeanMove(new Vector3(-canv.sizeDelta.x, -canv.sizeDelta.y, 0), 0f);
        }
        else
        {
            canv.LeanScale(new Vector3(1, 1), 0f);
            canv.LeanMove(new Vector3(-canv.sizeDelta.x / 2, -canv.sizeDelta.y / 2, 0), 0f);
        }

        if (scene.name == "1")
        {
            location.anchoredPosition = new Vector2(55.1f, 196.6f);
        }
        if(scene.name == "2")
        {
            location.anchoredPosition = new Vector2(54.7f, 229.4f);
        }
        if(scene.name == "3")
        {
            location.anchoredPosition = new Vector2(34.1f, 230.3f);
        }
        if(scene.name == "4")
        {
            location.anchoredPosition = new Vector2(-16f, 230.3f);
        }
        if(scene.name == "5")
        {
            location.anchoredPosition = new Vector2(-35f, 230.3f);
        }
        if(scene.name == "6")
        {
            location.anchoredPosition = new Vector2(-74.5f, 230.3f);
        }
        if(scene.name == "7")
        {
            location.anchoredPosition = new Vector2(-115f, 230.3f);
        }
        if(scene.name == "8")
        {
            location.anchoredPosition = new Vector2(-116.1f, 206.5f);
        }
        if(scene.name == "9")
        {
            location.anchoredPosition = new Vector2(-115.2f, 185.7f);
        }
        if(scene.name == "11")
        {
            location.anchoredPosition = new Vector2(-114.9f, 159.5f);
        }
        if(scene.name == "12")
        {
            location.anchoredPosition = new Vector2(-113.9f, 130.3f);
        }
        if(scene.name == "13")
        {
            location.anchoredPosition = new Vector2(-114.4f, 97.7f);
        }
        if(scene.name == "14")
        {
            location.anchoredPosition = new Vector2(-114.4f, 77.4f);
        }
        if(scene.name == "15")
        {
            location.anchoredPosition = new Vector2(-114.4f, 57.1f);
        }
        if(scene.name == "16")
        {
            location.anchoredPosition = new Vector2(-113.7f, 28.3f);
        }
        if(scene.name == "17")
        {
            location.anchoredPosition = new Vector2(-94.5f, 127.5f);
        }
        if(scene.name == "18")
        {
            location.anchoredPosition = new Vector2(-58.2f, 127.8f);
        }
        if(scene.name == "19")
        {
            location.anchoredPosition = new Vector2(-11.6f, 127.6f);
        }
        if(scene.name == "20")
        {
            location.anchoredPosition = new Vector2(14f, 127.3f);
        }
        if(scene.name == "21")
        {
            location.anchoredPosition = new Vector2(34.9f, 127.5f);
        }
        if(scene.name == "22")
        {
            location.anchoredPosition = new Vector2(54.9f, 155.4f);
        }
        if(scene.name == "23")
        {
            location.anchoredPosition = new Vector2(54.6f, 127.5f);
        }
        if(scene.name == "24")
        {
            location.anchoredPosition = new Vector2(54f, 101.1f);
        }
        if(scene.name == "25")
        {
            location.anchoredPosition = new Vector2(54f, 53.2f);
        }
        if(scene.name == "26")
        {
            location.anchoredPosition = new Vector2(54f, 16.9f);
        }
        if(scene.name == "27")
        {
            location.anchoredPosition = new Vector2(53.6f, -11.3f);
        }
        if(scene.name == "28")
        {
            location.anchoredPosition = new Vector2(99.7f, -9.1f);
        }
        if(scene.name == "29")
        {
            location.anchoredPosition = new Vector2(167.5f, -9.1f);
        }
        if(scene.name == "30")
        {
            location.anchoredPosition = new Vector2(22.2f, -10.7f);
        }
        if(scene.name == "31")
        {
            location.anchoredPosition = new Vector2(-8.8f, -17.7f);
        }
        if(scene.name == "32")
        {
            location.anchoredPosition = new Vector2(-42.9f, -24.1f);
        }
        if(scene.name == "33")
        {
            location.anchoredPosition = new Vector2(-86.3f, -23.1f);
        }
        if(scene.name == "34")
        {
            location.anchoredPosition = new Vector2(-114.7f, -22.6f);
        }
        if(scene.name == "35")
        {
            location.anchoredPosition = new Vector2(-135.3f, -50.3f);
        }
        if(scene.name == "36")
        {
            location.anchoredPosition = new Vector2(202.7f, 182.8f);
        }
        if(scene.name == "37")
        {
            location.anchoredPosition = new Vector2(201.6f, 128.7f);
        }
        if(scene.name == "38")
        {
            location.anchoredPosition = new Vector2(203.9f, 107f);
        }
        if(scene.name == "39")
        {
            location.anchoredPosition = new Vector2(222.1f, 89.8f);
        }
        if(scene.name == "40")
        {
            location.anchoredPosition = new Vector2(221.9f, 72.6f);
        }
        if(scene.name == "41")
        {
            location.anchoredPosition = new Vector2(221.6f, 52.9f);
        }
        if(scene.name == "42")
        {
            location.anchoredPosition = new Vector2(220.8f, 4.3f);
        }
        if(scene.name == "43")
        {
            location.anchoredPosition = new Vector2(220.6f, -23.8f);
        }
        if(scene.name == "44")
        {
            location.anchoredPosition = new Vector2(220.6f, -48.2f);
        }
        if(scene.name == "45")
        {
            location.anchoredPosition = new Vector2(222f, -94.2f);
        }
        if(scene.name == "46")
        {
            location.anchoredPosition = new Vector2(224f, -119.5f);
        }
        if(scene.name == "47")
        {
            location.anchoredPosition = new Vector2(257.5f, -129.1f);
        }
        if(scene.name == "48")
        {
            location.anchoredPosition = new Vector2(258.6f, -138.9f);
        }
        if(scene.name == "49")
        {
            location.anchoredPosition = new Vector2(259f, -154.4f);
        }
        if(scene.name == "50")
        {
            location.anchoredPosition = new Vector2(258.6f, -178.6f);
        }
        if(scene.name == "51")
        {
            location.anchoredPosition = new Vector2(257.9f, -204.6f);
        }
    }

    public void ChangeSize()
    {
        if (!isLarge)
        {
            canv.LeanScale(new Vector3(Screen.width / canv.sizeDelta.x, Screen.width / canv.sizeDelta.y), 0.3f);
            canv.LeanMove(new Vector3(-canv.sizeDelta.x * 1.2f, -canv.sizeDelta.y * 1.2f, 0), 0.3f);
            isLarge = true;
        }
        else
        {
            canv.LeanScale(new Vector3(1, 1), 0.3f);
            canv.LeanMove(new Vector3(-canv.sizeDelta.x / 2f, -canv.sizeDelta.y / 2f, 0), 0.3f);
            isLarge = false;
        }
    }
}
