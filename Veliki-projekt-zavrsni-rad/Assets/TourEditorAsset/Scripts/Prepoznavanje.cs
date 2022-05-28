using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class Prepoznavanje : MonoBehaviour
{
    public GameObject[] Buttons;
    public Graph myGraph;
    int index;
    public Material materijal;
    void Start()
    {
        Scene scena = SceneManager.GetActiveScene();
        Pomicanje pomicanje;
        Buttons = GameObject.FindGameObjectsWithTag("Gumb");
        for (int i = 0; i < myGraph.nodes.Count; i++)
        {
            //Debug.Log(myGraph.nodes[i].ToString() + " || " + scena + " (Node)");
            if (myGraph.nodes[i].ToString() == scena.name + " (Node)")
            {
                index = i;
            }
        }

        Path path = myGraph.GetShortestPath(myGraph.nodes[index], myGraph.nodes[30]);
        int d = 0;
        //Debug.Log("scena" + scena.name);
        foreach (GameObject i in Buttons)
        {
            pomicanje = Buttons[d].GetComponent<Pomicanje>();
            //Debug.Log(pomicanje.scena + " Mozda dela");
            //Debug.Log(pomicanje.scena + " ||| " + path.nodes[1].ToString());
            if(pomicanje.scena+" (Node)"==path.nodes[1].ToString())
            {
                //Debug.Log(Buttons[d] + " daj bože");
                Buttons[d].GetComponent<MeshRenderer>().material=materijal;
            }            
            d++;
        }
    }

   
}
