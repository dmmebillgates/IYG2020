using UnityEngine;

public class Moon : MonoBehaviour
{
    public Transform player;
    public Transform moon;
    
    void Update() => moon.transform.position = new Vector2(player.transform.position.x * 0.6f, -2f);
}