using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveableObject : MonoBehaviour
{
    public Renderer myRenderer;
    void CheckForClick()
    {
        Vector3 positionToCheck = ClickManager.mousePosition;
        positionToCheck.z = myRenderer.bounds.center.z;
        if (myRenderer.bounds.Contains(positionToCheck))
        {
            ClickManager.selectedObject = gameObject;
        }
    }
    void OnEnable()
    {
        ClickManager.OnMouseClick += CheckForClick;
    }
    void OnDisable()
    {
        ClickManager.OnMouseClick -= CheckForClick;
    }
}