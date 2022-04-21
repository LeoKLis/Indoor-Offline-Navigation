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

    private new readonly Rigidbody rigidbody;
    
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            rotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivityX * -1;
            rotationY += Input.GetAxis("Mouse Y") * sensitivityY * -1;
            rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);
            transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);
        }
    }

    void Start()
    {
        transform.Rotate(-rotationY, rotationX, 0);
        if (rigidbody)
        {
            rigidbody.freezeRotation = true;
        }
    }
}