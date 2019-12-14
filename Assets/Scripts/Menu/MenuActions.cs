using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuActions : MonoBehaviour
{
    // Main menu script
    public string action;
    public int sceneCount;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Check action
            switch (action)
            {
                // Load level
                case "load": SceneManager.LoadScene(sceneCount); break;

                // Exit
                case "exit": Application.Quit(); break;
            }
        }
    }
}
