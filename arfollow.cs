using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arfollow : MonoBehaviour
{
    public GameObject Player;
    public float positionSmoothSpeed = 0.125f;
    public float rotationSmoothSpeed = 0.125f;

    // Update is called once per frame
    void Update()
    {
        // Smoothly interpolate the position
        Player.transform.position = Vector3.Lerp(Player.transform.position, transform.position, positionSmoothSpeed);

        // Smoothly interpolate the rotation
        Player.transform.rotation = Quaternion.Slerp(Player.transform.rotation, transform.rotation, rotationSmoothSpeed);
    }
}
