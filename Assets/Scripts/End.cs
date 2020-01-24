using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    public Collider2D DeathMap;  // Tile map => 'DeathGround'

    void Update()
    {
        // Death
        if (CheckDeath()) Reload();
        // End
        if (CheckEnd()) GoToMenu();
    }

    #region Check

    private bool CheckDeath() => GetComponent<Collider2D>().IsTouching(DeathMap) && !Input.GetKeyDown(KeyCode.R);
    private bool CheckEnd() => GetComponent<PlayerMovement2D>().End;

    #endregion

    #region Private Methods

    /// <summary>
    /// Reload level if player die
    /// </summary>
    private void Reload()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.buildIndex);
    }

    /// <summary>
    /// Let player go back to main menu after end level
    /// </summary>
    private void GoToMenu()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            int menuScene = 0;
            SceneManager.LoadScene(menuScene);
        }
    }

    #endregion
}