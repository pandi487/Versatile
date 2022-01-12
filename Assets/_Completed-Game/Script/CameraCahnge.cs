using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCahnge : MonoBehaviour
{

    public Camera camera1;
    public Camera camera2;
    public Camera camera3;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F10))
        {
            camera1.gameObject.active = true;
            camera2.gameObject.active = false;
            camera3.gameObject.active = false;
        }
        if (Input.GetKeyDown(KeyCode.F11))
        {
            camera1.gameObject.active = false;
            camera2.gameObject.active = true;
            camera3.gameObject.active = false;

        }
        if (Input.GetKeyDown(KeyCode.F12))

        {
            camera1.gameObject.active = false;
            camera2.gameObject.active = false;
            camera3.gameObject.active = true;

        }

    }
}
