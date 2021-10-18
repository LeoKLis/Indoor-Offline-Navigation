using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEditor.SceneManagement;
using System;
using System.Collections;

public class TourMaker : EditorWindow
{

    int id;
    GameObject objectToSpawn;
    Material ImageMaterial;
    float objectScale;


    [MenuItem("Tools/TourMaker")]
    private static void ShowWindow()
    {
        var window = GetWindow<TourMaker>();
        window.titleContent = new GUIContent("TourMaker");
        window.Show();
    }

    private void OnGUI()
    {
        GUILayout.Label("Nova slika", EditorStyles.boldLabel);


        id = EditorGUILayout.IntField("Object ID", id);
        objectScale = 1f;

        objectToSpawn = EditorGUILayout.ObjectField("Prefab sfere", objectToSpawn, typeof(GameObject), false) as GameObject;
        ImageMaterial = EditorGUILayout.ObjectField("Prefab sfere", ImageMaterial, typeof(Material), false) as Material;

        if (GUILayout.Button("Spawn Object"))
        {
            SpawnObject();
        }

    }

    private void SpawnObject()
    {
        if (objectToSpawn == null)
        {
            Debug.LogError("Prefab didn't assigned");
            return;
        }


        //var spawnPos = new Vector3(0f, 0f, 0f);
        var newScene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Additive);
        string[] path = EditorSceneManager.GetActiveScene().path.Split(char.Parse("/"));
        bool saveOK = EditorSceneManager.SaveScene(EditorSceneManager.GetActiveScene(), string.Join("/", path));
        Debug.Log("Saved Scene " + (saveOK ? "OK" : "Error!"));
        EditorSceneManager.SaveOpenScenes();
        SceneManager.MoveGameObjectToScene(objectToSpawn, SceneManager.GetSceneByName("6"));
        /*var newObject = Instantiate(objectToSpawn, spawnPos, Quaternion.identity);
        newObject.name = "slika"+id;
        newObject.transform.localScale = Vector3.one * objectScale;
        newObject.GetComponent<MeshRenderer>().material = ImageMaterial;
        id++;*/

    }
}