using UnityEngine;

public class ARFollow : MonoBehaviour
{
    public GameObject Player;
    public float positionSmoothSpeed = 0.125f;
    public float rotationSmoothSpeed = 0.125f;

    private bool isEnabled = true;

    void Update()
    {
        if (isEnabled)
        {
            // Smoothly interpolate the position
            Player.transform.position = Vector3.Lerp(Player.transform.position, transform.position, positionSmoothSpeed);
            // Smoothly interpolate the rotation
            Player.transform.rotation = Quaternion.Slerp(Player.transform.rotation, transform.rotation, rotationSmoothSpeed);
        }
    }

    public void ToggleScript(bool enable)
    {
        isEnabled = enable;
    }
}
