using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void LoadLevel(int level)
    {
        // Load next level in queue
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + level);
    }

    public void ExitGame()
    {
        // Exit game
        Application.Quit();
    }

}
