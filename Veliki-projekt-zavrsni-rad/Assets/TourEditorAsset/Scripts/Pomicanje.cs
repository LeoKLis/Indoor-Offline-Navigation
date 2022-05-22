using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pomicanje : MonoBehaviour
{
    public string scena;
    int index;
    public Graph myGraph;
    public GameObject[] gameObjects;
    public static string rotCheck;
    Prepoznavanje prepoznavanje;
    // Update is called once per frame
    //Camera.main.fieldOfView = Mathf.Lerp(Camera.main.fieldOfView, Camera.main.fieldOfView - 50, 0.5f);


    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            
            
            int a = 0;
            
            if (Physics.Raycast(ray, out hit, 100.0f))
            {

                if (hit.collider.gameObject.CompareTag("Gumb1") || hit.collider.gameObject.CompareTag("Gumb2") || hit.collider.gameObject.CompareTag("Gumb3"))
                {
                    rotCheck = gameObject.tag;
                    SceneManager.LoadScene(scena);
                    for (int i=0;i<myGraph.nodes.Count;i++)
                    {
                        if(myGraph.nodes[i].ToString()==scena+" (Node)")
                        {
                            index = i;
                        }
                    }
                    //Debug.Log("index: " + index+" "+myGraph.nodes[index] );
                    Path path = myGraph.GetShortestPath(myGraph.nodes[index], myGraph.nodes[30]);
                    //Debug.Log("Slijedeci korak: " + path.nodes[1]);
                    Prepoznavanje kod;
                    
                    
                    

                    /*for (int i = 0; i < path.nodes.Count; i++)
                    {
                        Debug.Log(path.nodes[i]);
                    }*/
                    /*Pomicanje pomicanje;
                    Buttons = GameObject.FindGameObjectsWithTag("Gumb");
                    
                    
                    foreach (GameObject i in Buttons)
                    {

                        pomicanje = Buttons[d].GetComponent<Pomicanje>();
                        Debug.Log(pomicanje.scena + " Mozda dela");
                        d++;
                    }
                    d = 0;*/
                }

            }

        }
    }

    public string GetCheck()
    {
        return rotCheck;
    }
}
