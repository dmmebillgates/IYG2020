using UnityEngine;

public class Parallax : MonoBehaviour
{
    public Transform player;

    // Background Position
    public float YPos;
    public float ParallaxValue;

    void FixedUpdate() => GetComponent<Transform>().position =
        new Vector2(player.transform.position.x * ParallaxValue, YPos);
}