using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

public class MouseHandler : MonoBehaviour
{
    public Camera camera;

    private void Update()
    {
        MouseControl();
    }

    private void MouseControl()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            Vector2 pos = camera.ScreenToWorldPoint(Input.mousePosition);
            Debug.Log(pos);

        }
    }

}
