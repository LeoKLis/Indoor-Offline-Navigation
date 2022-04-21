using UnityEngine;
using System;

namespace Ed
{
    public class TourMaker : UnityEditor.EditorWindow
    { 
        Vector2 scrollPosition = Vector2.zero;
        GameObject objectToSpawn;
        Material[] ImageMaterial;
        int n;
        readonly float objectScale = 10f;
        Camera kamera;
        [UnityEditor.MenuItem("Tools/TourMaker")]
       
        private static void ShowWindow()
        {
            var window = GetWindow<TourMaker>();
            window.titleContent = new GUIContent("TourMaker");
            window.Show();
        }

        private void OnGUI()
        {            
            GUILayout.Label("Nova slika", UnityEditor.EditorStyles.boldLabel);
            n = UnityEditor.EditorGUILayout.IntField("Number of clones:", n);

            objectToSpawn = UnityEditor.EditorGUILayout.ObjectField("Prefab sfere", objectToSpawn, typeof(GameObject), false) as GameObject;

            kamera = UnityEditor.EditorGUILayout.ObjectField("Kamera:", kamera, typeof(Camera), false) as Camera;

            Array.Resize(ref ImageMaterial, n);
            scrollPosition = GUILayout.BeginScrollView(scrollPosition, true, true);
            for (int i = 0; i < n; i++)
            {
                ImageMaterial[i] = UnityEditor.EditorGUILayout.ObjectField("Materijal slike broj: "+i, ImageMaterial[i], typeof(Material), false) as Material;
            }
            GUILayout.EndScrollView();
            if (GUILayout.Button("Stvori sliku"))
            {
                SpawnObject();
            }
        }

        private void SpawnObject()
        {
            for (int i = 0; i < n; i++)
            {
                var newScene = UnityEditor.SceneManagement.EditorSceneManager.NewScene(UnityEditor.SceneManagement.NewSceneSetup.EmptyScene, UnityEditor.SceneManagement.NewSceneMode.Single);
                string[] path = UnityEngine.SceneManagement.SceneManager.GetActiveScene().path.Split(char.Parse("/"));
                var spawnPos = new Vector3(0f, 0f, 0f);
                var newObject = Instantiate(objectToSpawn, spawnPos, Quaternion.identity);
                newObject.transform.localScale = Vector3.one * objectScale;
                newObject.GetComponent<MeshRenderer>().material = ImageMaterial[i];
                var newKamera = Instantiate(kamera, spawnPos, Quaternion.identity);
                newKamera.transform.localScale = Vector3.one;
                GameObject lightGameObject = new GameObject("The Light");
                Light lightComp = lightGameObject.AddComponent<Light>();
                bool saveOK = UnityEditor.SceneManagement.EditorSceneManager.SaveScene(UnityEditor.SceneManagement.EditorSceneManager.GetActiveScene(), string.Join("/", path));
                Debug.Log(newScene.path);
                Debug.Log("Saved Scene " + (saveOK ? "OK" : "Error!"));
            }
        }
    }

}