using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public static bool visible;
    float rotationOnX;
    float mouseSensivity = 90f;
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = !Cursor.visible;
        //Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * mouseSensivity;
        float m_X = Input.GetAxis("Mouse X") * Time.deltaTime * mouseSensivity;

        rotationOnX -= mouseY;
        rotationOnX = Mathf.Clamp(rotationOnX, -90f, 0f);
        transform.localEulerAngles = new Vector3(rotationOnX, 0f, 0f);

        player.Rotate(Vector3.up * m_X);

    }
}
