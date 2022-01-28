using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEditor.SceneManagement;
using System;
using System.Collections;

namespace Ed
{
    public class TourMaker : EditorWindow
    {


        GameObject objectToSpawn;
        Material[] ImageMaterial;
        int n;
        float objectScale = 10f;
        Camera kamera;

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
            n = EditorGUILayout.IntField("Number of clones:", n);

            objectToSpawn = EditorGUILayout.ObjectField("Prefab sfere", objectToSpawn, typeof(GameObject), false) as GameObject;

            kamera = EditorGUILayout.ObjectField("Kamera:", kamera, typeof(Camera), false) as Camera;

            Array.Resize<Material>(ref ImageMaterial, n);

            for (int i = 0; i < n; i++)
            {
                ImageMaterial[i] = EditorGUILayout.ObjectField("Materijal slike broj: "+i+1, ImageMaterial[i], typeof(Material), false) as Material;
            }
            if (GUILayout.Button("Stvori sliku"))
            {
                SpawnObject();
            }


        }

        private void SpawnObject()
        {



            for (int i = 0; i < n; i++)
            {
                var newScene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
                string[] path = EditorSceneManager.GetActiveScene().path.Split(char.Parse("/"));
                var spawnPos = new Vector3(0f, 0f, 0f);
                var newObject = Instantiate(objectToSpawn, spawnPos, Quaternion.identity);
                newObject.transform.localScale = Vector3.one * objectScale;
                newObject.GetComponent<MeshRenderer>().material = ImageMaterial[i];
                var newKamera = Instantiate(kamera, spawnPos, Quaternion.identity);
                newKamera.transform.localScale = Vector3.one;
                GameObject lightGameObject = new GameObject("The Light");
                Light lightComp = lightGameObject.AddComponent<Light>();
                EditorSceneManager.SaveOpenScenes();
                EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo();
                bool saveOK = EditorSceneManager.SaveScene(EditorSceneManager.GetActiveScene(), string.Join("/", path));
                Debug.Log(newScene.path);
                Debug.Log("Saved Scene " + (saveOK ? "OK" : "Error!"));
            }
        }
    }

}