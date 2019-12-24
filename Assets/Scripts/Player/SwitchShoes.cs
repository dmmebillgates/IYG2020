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

    // Increase values
    public int increasedSpeed = 50;


    void Update()
    {
        if (Input.GetButtonUp("Shoe0"))
        {
            // Higher Jump
            CurrentShoe = 0;
            PlayerMovement2D.runSpeed = defaultSpeed;
            Rigidbody2D.gravityScale = 1;
            Player.transform.Rotate(new Vector3(0, 0, 0));
            

        }
        else if (Input.GetButtonUp("Shoe1"))
        {
            // Increases your movement speed
            CurrentShoe = 1;
            PlayerMovement2D.runSpeed = increasedSpeed;
            Rigidbody2D.gravityScale = 3;
            Player.transform.Rotate(new Vector3(0, 0, 0));
            


        }
        else if (Input.GetButtonUp("Shoe2"))
        {
            // Flips player upside down
            CurrentShoe = 2;
            PlayerMovement2D.runSpeed = defaultSpeed;
            Rigidbody2D.gravityScale = -1;
            Player.transform.Rotate(new Vector3(0, 0, -180));
            SpriteRenderer.flipX = true;
            


        }
        else if (Input.GetButtonUp("Shoe3"))
        {
            // reduces size of the player
            CurrentShoe = 3;
            PlayerMovement2D.runSpeed = defaultSpeed;
            Rigidbody2D.gravityScale = 3;
            Player.transform.Rotate(new Vector3(0, 0, 0));
            transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);

        }

    }

}


