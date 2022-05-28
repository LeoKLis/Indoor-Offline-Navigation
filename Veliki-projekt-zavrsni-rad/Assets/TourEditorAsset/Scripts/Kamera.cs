using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kamera : MonoBehaviour
{
    public float sensitivityX = 1.6f;
    public float sensitivityY = 1.5f;

    public float minimumX = -360f;
    public float maximumX = 360f;

    public float minimumY = -60f;
    public float maximumY = 60f;

    public float h = 0;

    public static float rotationY;
    public static float rotationX;

    public GameObject target;

    private new readonly Rigidbody rigidbody;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Gumb1");
        Pomicanje var = FindObjectOfType<Pomicanje>();
        if(var.GetCheck() == "Gumb1")
        {
            if (GameObject.FindGameObjectWithTag("Gumb1"))
            {
                target = GameObject.FindGameObjectWithTag("Gumb1");
            }
            else
            {
                target = GameObject.FindGameObjectWithTag("Gumb2");
            }
            
        }
        else if (var.GetCheck() == "Gumb2")
        {
            if (GameObject.FindGameObjectWithTag("Gumb2"))
            {
                target = GameObject.FindGameObjectWithTag("Gumb2");
            }
            else
            {
                target = GameObject.FindGameObjectWithTag("Gumb1");
            }
        }
        else if (var.GetCheck() == "Gumb3")
        {
            target = GameObject.FindGameObjectWithTag("Gumb1");
        }
        else
        {
            Debug.Log("Onda ne radi");
        }
        
        Vector3 targetDir = target.transform.position - transform.position;
        Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, 5, 0.0f);
        transform.rotation = Quaternion.LookRotation(newDir);
        if (rigidbody)
        {
            rigidbody.freezeRotation = true;
        }
    }

    void Update()
    {
//#if UNITY_ANDROID
        /*if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            rotationX = transform.localEulerAngles.y + touch.deltaPosition.x * sensitivityX/40 * -1;
            rotationY += touch.deltaPosition.y * sensitivityY/40 * -1;
            rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);
            transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);
        }*/
//#elif UNITY_EDITOR_WIN
        if (Input.GetMouseButton(0))
        {
            rotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivityX * -1;
            rotationY = transform.localEulerAngles.x + Input.GetAxis("Mouse Y") * sensitivityY;
            transform.localEulerAngles = new Vector3(rotationY, rotationX, 0);
        }
//#endif
    }
}