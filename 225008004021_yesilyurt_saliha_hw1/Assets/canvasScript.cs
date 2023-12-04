using UnityEngine;

public class CanvasCameraFinder : MonoBehaviour
{
    void Start()
    {
        // If the Event Camera is not assigned
        if (GetComponent<Canvas>().renderMode == RenderMode.WorldSpace && GetComponent<Canvas>().worldCamera == null)
        {
            // Find any camera in the scene
            Camera mainCamera = GameObject.FindObjectOfType<Camera>();

            // If a camera is found, set Canvas's Event Camera to that
            if (mainCamera != null)
            {
                GetComponent<Canvas>().worldCamera = mainCamera;
            }
            else
            {
                Debug.LogError("No camera found in the scene. Please assign a camera to the Canvas's Event Camera manually.");
            }
        }
    }
}