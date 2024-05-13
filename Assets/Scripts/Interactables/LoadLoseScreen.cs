using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLoseScreen : MonoBehaviour
{
    public string LoseScreen; // Name of the scene to load

    private void OnTriggerEnter(Collider DamageFloor)
    {
        if (DamageFloor.CompareTag("Player"))
        {
            SceneManager.LoadScene(LoseScreen);
            Debug.Log("Works");
        }
    }
}