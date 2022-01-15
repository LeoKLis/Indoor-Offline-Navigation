using UnityEngine;
using System.Collections;
public class Kamera : MonoBehaviour
{
  

    public float sensitivityX = 1.6f;
    public float sensitivityY = 1.5f;

    public float minimumX = -360f;
    public float maximumX = 360f;

    public float minimumY = -60f;
    public float maximumY = 60f;

    public float h = -180;

    float rotationY = 0f;

    new readonly Rigidbody rigidbody;
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            
                float rotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivityX;
                rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
                rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);
                transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);
           
        }
    }

    void Start()
    {
        transform.Rotate(h, 0, 0);
        if (rigidbody)
            rigidbody.freezeRotation = true;
    }

}