using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    // Name of the scene to load
    public string EscapeOutside;

    // This method is called when the collider enters the trigger collider
    private void OnTriggerEnter(Collider other)
    {
        // Debug log to check if collision is detected
        Debug.Log("Collision detected with: " + other.name);

        // Check if the colliding object has the tag "Player"
        if (other.CompareTag("Player"))
        {
            // Debug log to confirm player tag is detected
            Debug.Log("Player detected, loading scene: " + EscapeOutside);

            // Load the specified scene
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
    }
}