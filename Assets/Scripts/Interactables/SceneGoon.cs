using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneGoon : MonoBehaviour
{
    // The name of the scene to load
    public string WinScreen;

    // Time to wait before loading the new scene (in seconds)
    public float delay = 28.47f;

    // Timer to keep track of elapsed time
    private float timer = 0f;

    void Start()
    {
        if (string.IsNullOrEmpty(WinScreen))
        {
            Debug.LogError("Scene name is not set. Please set the scene name in the inspector.");
        }
    }

    void Update()
    {
        // Increment the timer by the time that has passed since the last frame
        timer += Time.deltaTime;

        // Check if the timer has reached the delay
        if (timer >= delay)
        {
            // Load the specified scene
            Debug.Log($"Loading scene '{WinScreen}' after {delay} seconds");
            SceneManager.LoadScene(WinScreen);

            // Prevent further updates once the scene is loaded
            enabled = false;
        }
    }
}