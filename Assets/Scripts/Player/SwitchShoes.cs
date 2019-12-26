using UnityEngine;

public class SwitchShoes : MonoBehaviour
{
    public PlayerMovement2D PlayerMovement2D;
    public CharacterController2D PlayerController2D;
    public Rigidbody2D Player;
    public Rigidbody2D Rigidbody2D;
    public SpriteRenderer SpriteRenderer;



    public int CurrentShoe;

    // Default values
    public int defaultSpeed = 25;
    public int defaultGravityScale = 3;
    public Vector3 defaultSize = new Vector3(1f, 1f, 1f);

    // Increase values
    public int increasedSpeed = 50;
    public int increasedGravityScale = 1;
    public Vector3 smallSize = new Vector3(0.4f, 0.4f, 0.4f);


    void Update()
    {
        if (Input.GetButtonUp("Shoe0"))
        {
            // Default shoes nothing increase 
            CurrentShoe = 0;

            PlayerMovement2D.runSpeed = defaultSpeed;
            transform.localScale = defaultSize;
            Rigidbody2D.gravityScale = defaultGravityScale;

        }
        else if (Input.GetButtonUp("Shoe1"))
        {
            // Higher Jump
            CurrentShoe = 1;

            PlayerMovement2D.runSpeed = defaultSpeed;
            Rigidbody2D.gravityScale = increasedGravityScale;
            transform.localScale = defaultSize;
        }
        else if (Input.GetButtonUp("Shoe2"))
        {
            // Increases your movement speed
            CurrentShoe = 2;

            PlayerMovement2D.runSpeed = increasedSpeed;
            transform.localScale = defaultSize;
            Rigidbody2D.gravityScale = defaultGravityScale;
        }
        else if (Input.GetButtonUp("Shoe3"))
        {
            // Reduces size of the player
            CurrentShoe = 3;

            PlayerMovement2D.runSpeed = defaultSpeed;
            transform.localScale = smallSize;
            Rigidbody2D.gravityScale = defaultGravityScale;
        }
    }

}


