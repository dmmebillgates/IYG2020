using UnityEngine;

public class Parallax : MonoBehaviour
{
    public float PositionY;
    public float PositionXStart;
    public float ParallaxStrong;
    public Transform PlayerPosition;

    void Start() => GetComponent<Transform>().position = new Vector2(PositionXStart, PositionY);
    void FixedUpdate() => GetComponent<Transform>().position = new Vector2(PositionXStart + PlayerPosition.position.x * ParallaxStrong, PositionY) ;
}
