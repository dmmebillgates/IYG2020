using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    // Player and objects what can kill him
    public Collider2D Player;
    public Collider2D DeathMap;

    void Update()
    {
        if (!Player.IsTouching(DeathMap) && !Input.GetKeyDown(KeyCode.R)) return;
        
        int sameScene = SceneManager.sceneCountInBuildSettings - 1;
        SceneManager.LoadScene(sameScene);
    }
}