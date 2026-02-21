using UnityEngine;

public class MouseMovement : MonoBehaviour
{

    public Transform playerBody;
    public float sensitivity = 100f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    float xRotation = 0f;
    void Start()

    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {

        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * sensitivity;

        playerBody.Rotate(Vector3.up * mouseX);


        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);


        
    }
}
