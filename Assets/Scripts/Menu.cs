using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    void Start() => Cursor.visible = true; // Show cursor in menu

    public void LoadLevel(int level) =>
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + level); // Load next level 

    public void ExitGame() => Application.Quit(); // Exit
}