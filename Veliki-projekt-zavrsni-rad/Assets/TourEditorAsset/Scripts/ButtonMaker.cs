using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEditor.SceneManagement;
public class ButtonMaker : EditorWindow
{
    static bool active;
    public GameObject gumb;
  
    [MenuItem("Tools/ButtonMaker")]
    static void Init()
    {
        var window = (ButtonMaker)EditorWindow.GetWindow(typeof(ButtonMaker));
        window.Show();
    }

  
    void OnEnable() => SceneView.duringSceneGui += OnSceneGUI;
    void OnDisable() => SceneView.duringSceneGui -= OnSceneGUI;

   
    void OnSceneGUI(SceneView view)
    {
        if (!active)
        {
            return;
        }

        if (Event.current.type == EventType.MouseDown)
        {
            Ray ray = HandleUtility.GUIPointToWorldRay(Event.current.mousePosition);
            RaycastHit hit;


            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("Hit: " + hit.collider.gameObject.name);


                GameObject obj = gumb;
                obj.transform.position = hit.point;
                
                Instantiate(obj);
                EditorSceneManager.SaveScene(EditorSceneManager.GetActiveScene());
                Event.current.Use();
            }
            
        }

        
    }

    
    void OnGUI()
    {
        if (GUILayout.Button("Enable Raycasting"))
        {
            active = !active;
        }

        GUILayout.Label("Active:" + active);
    }
}
