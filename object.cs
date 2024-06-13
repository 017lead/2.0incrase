using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    private Vector3 mousePosition;
    private Vector3 offset;
    private float zCoord;

    private Vector3 GetMouseWorldPos()
    {
        // Get the screen position of the mouse and set the z coordinate to the object's z coordinate
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = zCoord;

        // Convert screen position to world position
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    private void OnMouseDown()
    {
        // Capture the z coordinate of the object in world space
        zCoord = Camera.main.WorldToScreenPoint(transform.position).z;

        // Calculate the offset between the mouse position and the object position
        offset = transform.position - GetMouseWorldPos();
    }

    private void OnMouseDrag()
    {
        // Update the object's position while dragging, maintaining the initial offset
        transform.position = GetMouseWorldPos() + offset;
    }
}
