using UnityEngine;
using UnityEngine.SceneManagement;

public class Pomicanje : MonoBehaviour
{
    public string scena;
    // Update is called once per frame
    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                //Replace this with whatever logic you want to use to validate the objects you want to click on
                if (hit.collider.gameObject.CompareTag("Gumb"))
                {
                    Debug.Log("Dela");
                    SceneManager.LoadScene(scena);
                }
            }
        }
    }
}
