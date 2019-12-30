using UnityEngine;

public class Parallax : MonoBehaviour
{
    public Transform player;
    public Transform moon;
    public float YPos;
    public float ParallaxValue;
    
    
    void Update() => moon.transform.position = new Vector2(player.transform.position.x * ParallaxValue, YPos);
}