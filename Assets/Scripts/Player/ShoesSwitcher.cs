using UnityEngine;

public class ShoesSwitcher : MonoBehaviour
{
    public PlayerMovement2D PlayerMovement2D;
    public Rigidbody2D Rigidbody2D;
    public int CurrentShoe;

    // Default values
    public int DefaultSpeed = 25;
    public int DefaultGravityScale = 3;
    public Vector3 DefaultSize = new Vector3(1f, 1f, 1f);

    // Increase values
    public int IncreasedSpeed = 50;
    public int IncreasedGravityScale = 1;
    public Vector3 SmallSize = new Vector3(0.4f, 0.4f, 0.4f);


    void Update()
    {
        if (Input.GetButtonUp("Shoe1"))
        {
            // Default shoes nothing increase 
            CurrentShoe = 1;

            PlayerMovement2D.runSpeed = DefaultSpeed;
            transform.localScale = DefaultSize;
            Rigidbody2D.gravityScale = DefaultGravityScale;
        }
        else if (Input.GetButtonUp("Shoe2"))
        {
            // Higher Jump
            CurrentShoe = 2;

            PlayerMovement2D.runSpeed = DefaultSpeed;
            Rigidbody2D.gravityScale = IncreasedGravityScale;
            transform.localScale = DefaultSize;
        }
        else if (Input.GetButtonUp("Shoe3"))
        {
            // Increases your movement speed
            CurrentShoe = 3;

            PlayerMovement2D.runSpeed = IncreasedSpeed;
            transform.localScale = DefaultSize;
            Rigidbody2D.gravityScale = DefaultGravityScale;
        }
        else if (Input.GetButtonUp("Shoe4"))
        {
            // Reduces size of the player
            CurrentShoe = 4;
            
            // Jump
            PlayerMovement2D.jump = true;
            PlayerMovement2D.animator.SetBool("IsJumping", true);
            
            PlayerMovement2D.runSpeed = DefaultSpeed;
            transform.localScale = SmallSize;
            Rigidbody2D.gravityScale = DefaultGravityScale;
        }
        else if (Input.GetButtonUp("Shoe5"))
        {
            // Flip player upside down
            CurrentShoe = 5;

            PlayerMovement2D.runSpeed = DefaultSpeed;
            transform.localScale = DefaultSize;
            Rigidbody2D.gravityScale = -DefaultGravityScale;
            Rigidbody2D.transform.localScale = new Vector3(1, -1, 1);
        }
    }
}