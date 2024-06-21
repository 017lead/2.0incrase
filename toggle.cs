using UnityEngine;
using UnityEngine.UI;

public class ScriptToggler : MonoBehaviour
{
    public ARFollow arFollowScript;
    public GyroCameraController gyroCameraScript;
    public Button toggleButton;
    public Text buttonText;

    private bool isARFollowActive = true;

    private void Start()
    {
        // Ensure the initial state is correct
        arFollowScript.ToggleScript(true);
        gyroCameraScript.ToggleScript(false);

        // Add listener to the button
        toggleButton.onClick.AddListener(ToggleScripts);

        // Set initial button text
        UpdateButtonText();
    }

    private void ToggleScripts()
    {
        isARFollowActive = !isARFollowActive;

        arFollowScript.ToggleScript(isARFollowActive);
        gyroCameraScript.ToggleScript(!isARFollowActive);

        UpdateButtonText();
    }

    private void UpdateButtonText()
    {
        buttonText.text = isARFollowActive ? "Switch to Gyro" : "Switch to AR Follow";
    }
}