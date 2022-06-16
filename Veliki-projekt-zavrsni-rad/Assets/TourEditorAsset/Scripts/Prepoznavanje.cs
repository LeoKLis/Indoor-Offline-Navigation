using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class Prepoznavanje : MonoBehaviour
{
    public GameObject[] Buttons1;
    public GameObject[] Buttons2;
    public GameObject[] Buttons3;
    public Graph myGraph;
    private Text tekstNav;
    Pomicanje pomicanje;
    int index;
    ShowToast showToast;

    int cilj = -1;
    public Material materijal;
    public Material materijal2;
    public GameObject not;
    public GameObject tekst;
    string[,] dijkArray = new string[51, 2] { { "1", "WC2" },
                                              { "2", "40" },
                                              { "3", "/" },
                                              { "4", "PK" },
                                              { "5", "SO" },
                                              { "6", "/" },
                                              { "7", "RO" },
                                              { "8", "/" },
                                              { "9", "/" },
                                              { "10", "/" },
                                              { "11", "44" },
                                              { "12", "44a" },
                                              { "13", "45" },
                                              { "14", "48" },
                                              { "15", "47" },
                                              { "16", "STROJARSKI KABINET" },
                                              { "17", "43b" },
                                              { "18", "43" },
                                              { "19", "42" },
                                              { "20", "ST" },
                                              { "21", "41" },
                                              { "22", "39a" },
                                              { "23", "39" },
                                              { "24", "MATEMATICKI KABINET" },
                                              { "25", "40b" },
                                              { "26", "/" },
                                              { "27", "/" },
                                              { "28", "/" },
                                              { "29", "/" },
                                              { "30", "40a" },
                                              { "31", "ULAZ" },
                                              { "32", "/" },
                                              { "33", "WC1" },
                                              { "34", "REFERADA" },
                                              { "35", "KANTINA" },
                                              { "36", "33" },
                                              { "37", "30" },
                                              { "38", "/" },
                                              { "39", "WC3" },
                                              { "40", "29" },
                                              { "41", "28" },
                                              { "42", "27" },
                                              { "43", "26" },
                                              { "44", "25" },
                                              { "45", "17" },
                                              { "46", "24" },
                                              { "47", "/" },
                                              { "48", "/" },
                                              { "49", "18" },
                                              { "50", "22" },
                                              { "51", "21" } };
    void Start()
    {

        for (int i = 0; i < 51; i++)
        {
            Debug.Log(dijkArray[i, 1]);
        }
        tekst = GameObject.FindGameObjectWithTag("tekst");
        not = GameObject.FindGameObjectWithTag("Notifikacija");
        not.SetActive(false);
        tekstNav = tekst.GetComponent<Text>();
        Scene scena = SceneManager.GetActiveScene();
        
        Buttons1 = GameObject.FindGameObjectsWithTag("Gumb1");
        Buttons2 = GameObject.FindGameObjectsWithTag("Gumb2");
        Buttons3 = GameObject.FindGameObjectsWithTag("Gumb3");

        /*for (int i = 0; i < myGraph.nodes.Count; i++)
        {
            //Debug.Log(myGraph.nodes[i].ToString() + " || " + scena + " (Node)");
            if (myGraph.nodes[i].ToString() == scena.name + " (Node)")
            {
                index = i;
            }
        }
        
        Path path = myGraph.GetShortestPath(myGraph.nodes[index], myGraph.nodes[30]);
        int d = 0;
        Debug.Log("scena" + scena.name);
        if (myGraph.nodes[30].ToString() != scena.name.ToString() + " (Node)")
        {
            foreach (GameObject i in Buttons1)
            {
                pomicanje = Buttons1[d].GetComponent<Pomicanje>();
                //Debug.Log(pomicanje.scena + " Mozda dela");
                Debug.Log(Buttons1[d] + " daj bože");
                if (pomicanje.scena + " (Node)" == path.nodes[1].ToString())
                {
                    Debug.Log(Buttons1[d] + " daj bože");
                    Buttons1[d].GetComponent<MeshRenderer>().material = materijal;
                }
                d++;
            }
            d = 0;
            foreach (GameObject i in Buttons2)
            {
                pomicanje = Buttons2[d].GetComponent<Pomicanje>();
                //Debug.Log(pomicanje.scena + " Mozda dela");
                Debug.Log(Buttons2[d] + " daj bože");
                if (pomicanje.scena + " (Node)" == path.nodes[1].ToString())
                {
                    Debug.Log(Buttons2[d] + " daj bože");
                    Buttons2[d].GetComponent<MeshRenderer>().material = materijal;
                }
                d++;
            }
            d = 0;
            foreach (GameObject i in Buttons3)
            {
                pomicanje = Buttons3[d].GetComponent<Pomicanje>();
                //Debug.Log(pomicanje.scena + " Mozda dela");
                Debug.Log(Buttons3[d] + " daj bože");
                if (pomicanje.scena + " (Node)" == path.nodes[1].ToString())
                {
                    Debug.Log(Buttons3[d] + " daj bože");
                    Buttons3[d].GetComponent<MeshRenderer>().material = materijal;
                }
                d++;
            }
        }
        else
        {
            Debug.Log("Stigli ste");
        }
           */
    }

    void Put()
    {
        Scene scena = SceneManager.GetActiveScene();
        for (int i = 0; i < myGraph.nodes.Count; i++)
        {
            //Debug.Log(myGraph.nodes[i].ToString() + " || " + scena + " (Node)");
            if (myGraph.nodes[i].ToString() == scena.name + " (Node)")
            {
                index = i;
            }
        }

        Path path = myGraph.GetShortestPath(myGraph.nodes[index], myGraph.nodes[cilj]);
        int d = 0;
        // Debug.Log("scena" + scena.name);
        not.SetActive(false);
        if (myGraph.nodes[cilj].ToString() != scena.name.ToString() + " (Node)")
        {            
            foreach (GameObject i in Buttons1)
            {
                pomicanje = Buttons1[d].GetComponent<Pomicanje>();
                //Debug.Log(pomicanje.scena + " Mozda dela");
                //Debug.Log(Buttons1[d] + " daj bože");
                Buttons1[d].GetComponent<MeshRenderer>().material = materijal2;
                if (pomicanje.scena + " (Node)" == path.nodes[1].ToString())
                {
                    //Debug.Log(Buttons1[d] + " daj bože");
                    Buttons1[d].GetComponent<MeshRenderer>().material = materijal;
                }
                d++;
            }
            d = 0;
            foreach (GameObject i in Buttons2)
            {
                pomicanje = Buttons2[d].GetComponent<Pomicanje>();
                //Debug.Log(pomicanje.scena + " Mozda dela");
                // Debug.Log(Buttons2[d] + " daj bože");
                Buttons2[d].GetComponent<MeshRenderer>().material = materijal2;
                if (pomicanje.scena + " (Node)" == path.nodes[1].ToString())
                {
                    //Debug.Log(Buttons2[d] + " daj bože");
                    Buttons2[d].GetComponent<MeshRenderer>().material = materijal;
                }
                d++;
            }
            d = 0;
            foreach (GameObject i in Buttons3)
            {
                pomicanje = Buttons3[d].GetComponent<Pomicanje>();
                //Debug.Log(pomicanje.scena + " Mozda dela");
                // Debug.Log(Buttons3[d] + " daj bože");
                Buttons3[d].GetComponent<MeshRenderer>().material = materijal2;
                if (pomicanje.scena + " (Node)" == path.nodes[1].ToString())
                {
                    // Debug.Log(Buttons3[d] + " daj bože");
                    Buttons3[d].GetComponent<MeshRenderer>().material = materijal;
                }
                d++;
            }
        }
        else
        {
            foreach (GameObject i in Buttons1)
            {
                Buttons1[d].GetComponent<MeshRenderer>().material = materijal2;
            }
            foreach (GameObject i in Buttons2)
            {
                Buttons2[d].GetComponent<MeshRenderer>().material = materijal2;
            }
            foreach (GameObject i in Buttons3)
            {
                Buttons3[d].GetComponent<MeshRenderer>().material = materijal2;
            }


            not.SetActive(true);

            Debug.Log("Stigli ste");
        }
    }

 
    private void Update()
    {
        Debug.Log(tekstNav.text);
        int counter = 0;
        for (int i = 0; i < 51; i++)
        {
            if (tekstNav.text == dijkArray[i, 1])
            {
                for (int d = 0; d < myGraph.nodes.Count; d++)
                {
                    //Debug.Log("Scena: " + myGraph.nodes[d].ToString() + " " + dijkArray[i, 1] + " (Node)" + " " + d + " " + dijkArray[i, 0]);
                    if (myGraph.nodes[d].ToString() == dijkArray[i, 0] + " (Node)")
                    {
                        cilj = d;
                    }
                }


            }
            else
            {
                counter++;
            }

        }
        Debug.Log("Cilj" + cilj);
        if (counter == 51)
        {
            counter = 0;
            int j = 0;
            foreach (GameObject i in Buttons1)
            {


                Buttons1[j].GetComponent<MeshRenderer>().material = materijal2;
                j++;

            }
            j = 0;
            foreach (GameObject i in Buttons2)
            {


                Buttons2[j].GetComponent<MeshRenderer>().material = materijal2;
                j++;

            }
            j = 0;
            foreach (GameObject i in Buttons3)
            {


                Buttons3[j].GetComponent<MeshRenderer>().material = materijal2;
                j++;
            }
        }
        else
            Put();
    }
   

}

