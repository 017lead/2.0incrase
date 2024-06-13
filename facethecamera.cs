using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
    private Camera mainCamera;

    void Start()
    {
        // Find the main camera in the scene
        mainCamera = Camera.main;
    }

    void Update()
    {
        // Make the object face the camera in all axes
        transform.LookAt(mainCamera.transform);
    }
}
