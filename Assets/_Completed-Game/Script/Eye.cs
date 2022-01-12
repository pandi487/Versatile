using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Eye : MonoBehaviour
{
    Transform BG;
    Transform Point;

    float BGRadius = 0f;
    float PointRadius = 0f;

    float startRadius = 0f;
    float endRadius = 0f;
    Image render;
    Vector3 mousePoint = Vector3.zero;
    void Start()
    {
        render = GetComponent<Image>();
        BG = transform;
        Point = transform.GetChild(0).transform;
    }

    void Update()
    {
        mousePoint = Input.mousePosition;
        float angele = Mathf.Atan2(Point.position.y - mousePoint.y + Screen.height / 2, Point.position.x - mousePoint.x + Screen.width / 2) * Mathf.Rad2Deg;
        
        Point.eulerAngles = new Vector3(0, 0, angele);
        float Scroll = Input.GetAxis("Mouse ScrollWheel");

        float colorVal_R = (mousePoint.x  > (Screen.width / 2)) ? mousePoint.x + 255 / 2 
            : (Mathf.Abs(mousePoint.x ) % (255 / 2)) * -1;

        float colorVal_G = (mousePoint.y  > (Screen.height / 2)) ? mousePoint.y + 255 / 2 
            : (Mathf.Abs(mousePoint.y ) % (255 / 2)) * -1;

        //float colorVal_B = (Scroll > 0) ? Scroll * 172.5f + 255 / 2 : (Mathf.Abs(Scroll * 172.5f) % (255 / 2)) * -1;
        
        render.color = new Color(colorVal_R, colorVal_G, 0);
       // Debug.Log(colorVal_B);
    }
}

