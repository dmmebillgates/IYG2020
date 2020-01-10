using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public Collider2D DeathMap;

    void Update()
    {
        if (!GetComponent<Collider2D>().IsTouching(DeathMap) && !Input.GetKeyDown(KeyCode.R)) return;
        
        // Reload level if "if" statment is false
        Reload();
    }

    void Reload()
    {
        int sameScene = SceneManager.sceneCountInBuildSettings - 1;
        SceneManager.LoadScene(sameScene);
    }
}