using UnityEngine;
using UnityEngine.SceneManagement;

public class Pomicanje : MonoBehaviour
{
    public string scena;
    int index;
    public Graph myGraph;
    public GameObject[] gameObjects;
    Prepoznavanje prepoznavanje;
    // Update is called once per frame
    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            
            
            int a = 0;
            
            if (Physics.Raycast(ray, out hit, 100.0f))
            {

                //Replace this with whatever logic you want to use to validate the objects you want to click on

                if (hit.collider.gameObject.CompareTag("Gumb"))
                {
                    //Debug.Log("Dela");
                   
                   
                    SceneManager.LoadScene(scena);
                    //Debug.Log("scena" + scena);
                    
                        for (int i=0;i<myGraph.nodes.Count;i++)
                    {
                        //Debug.Log(myGraph.nodes[i].ToString() + " || " + scena + " (Node)");
                        if(myGraph.nodes[i].ToString()==scena+" (Node)")
                        {
                            index = i;
                        }
                    }
                    //Debug.Log("index: " + index+" "+myGraph.nodes[index] );
                    Path path = myGraph.GetShortestPath(myGraph.nodes[index], myGraph.nodes[30]);
                    Debug.Log("Slijedeci korak: " + path.nodes[1]);
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
}
