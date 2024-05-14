using UnityEngine;
using UnityEngine.UI;

public class CursorControl : MonoBehaviour
{
    public Button myButton;

    void Start()
    {
        // Ensure the cursor is visible and confined within the game window
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;

        // Assign the ButtonClick method to the button's onClick event
        if (myButton != null)
        {
            myButton.onClick.AddListener(ButtonClick);
        }
    }

    void ButtonClick()
    {
        // Code to execute when the button is clicked
        Debug.Log("Button clicked!");
    }

    void OnApplicationQuit()
    {
        // Ensure the cursor is unlocked when the application quits
        Cursor.lockState = CursorLockMode.None;
    }
}