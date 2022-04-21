using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chirent : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject image_parent;
    void Start()
    {
        image_parent = GameObject.FindWithTag("Image");
        this.transform.parent = image_parent.transform;
    }
}
