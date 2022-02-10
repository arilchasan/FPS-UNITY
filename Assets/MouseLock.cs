using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLock : MonoBehaviour
{
    float XRotation = 0f;

    public float mouseSensitifitas = 100f;

    public Transform playerbody;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mousex = Input.GetAxis("Mouse X") * mouseSensitifitas * Time.deltaTime;
        float mousey = Input.GetAxis("Mouse Y") * mouseSensitifitas * Time.deltaTime;
        XRotation -= mousey;
        XRotation = Mathf.Clamp(XRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(XRotation, 0f, 0f);
        playerbody.Rotate(Vector3.up * mousex);
    }
}
