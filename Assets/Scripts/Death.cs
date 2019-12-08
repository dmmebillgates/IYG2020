using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    // Player and objects what can kill him
    public Collider2D player;
    public Collider2D deathMap;

    void Update()
    {

        if(player.IsTouching(deathMap)|| (Input.GetKeyDown(KeyCode.R)))
        {
            int sameScene = SceneManager.sceneCountInBuildSettings - 1;
            SceneManager.LoadScene(sameScene);
        }
    }
}
