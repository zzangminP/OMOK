using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MouseHandler : MonoBehaviour
{

    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); 
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            Vector3 worldPosition = hit.point; 
            Debug.Log($"World Position: {worldPosition}");
        }
    }



}
