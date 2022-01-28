using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class saveScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo();
    }

    
}
