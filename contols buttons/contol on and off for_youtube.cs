using UnityEngine;
using UnityEngine.UI;
public class CanvasController : MonoBehaviour
{
    public Canvas canvas1; // Reference to the first canvas
    public Canvas canvas2; // Reference to the second canvas
    public Button enableButton; // Reference to the enable button
    public Button disableButton; // Reference to the disable button
    void Start()
    {
        // Add listeners to the buttons
        enableButton.onClick.AddListener(EnableCanvas1DisableCanvas2);
        disableButton.onClick.AddListener(EnableCanvas2DisableCanvas1);
        // Optionally, set initial states of the canvases
        canvas1.gameObject.SetActive(true);
        canvas2.gameObject.SetActive(false);
    }
    void EnableCanvas1DisableCanvas2()
    {
        canvas1.gameObject.SetActive(true);
        canvas2.gameObject.SetActive(false);
    }
    void EnableCanvas2DisableCanvas1()
    {
        canvas1.gameObject.SetActive(false);
        canvas2.gameObject.SetActive(true);
    }
}

