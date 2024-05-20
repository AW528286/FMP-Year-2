using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Name of the scene to load
    public string WinScreen;

    // This method is called when the collider enters the trigger collider
    private void OnTriggerEnter(Collider other)
    {
        // Debug log to check if collision is detected
        Debug.Log("Collision detected with: " + other.name);

        // Check if the colliding object has the tag "Player"
        if (other.CompareTag("Player"))
        {
            // Debug log to confirm player tag is detected
            Debug.Log("Player detected, loading scene: " + WinScreen);

            // Load the specified scene
            SceneManager.LoadScene(WinScreen);
        }
    }
}