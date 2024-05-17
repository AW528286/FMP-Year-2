using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLoseScreen : MonoBehaviour
{
    // Name of the scene to load
    public string LoseScreen;

    // This method is called when the collider enters the trigger collider
    private void OnTriggerEnter(Collider other)
    {
        // Check if the colliding object has the tag "Player"
        if (other.CompareTag("Player"))
        {
            // Load the specified scene
            SceneManager.LoadScene(LoseScreen);
        }
    }
}