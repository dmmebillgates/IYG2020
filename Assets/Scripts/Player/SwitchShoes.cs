using UnityEngine;

public class SwitchShoes : MonoBehaviour
{
    public PlayerMovement2D PlayerMovement2D;
    public CharacterController2D PlayerController2D;

    public int CurrentShoe;

    // Default values
    public int defaultSpeed = 25;
    public int defaultJump;

    // Increase values
    public int increaseSpeed = 50;
    public int increaseJump;

    void Update()
    {
        if (Input.GetButton("Shoe0"))
        {
            // Default shoe
            CurrentShoe = 0;
            PlayerMovement2D.runSpeed = defaultSpeed;
        }
        else if (Input.GetButton("Shoe1"))
        {
            // Increase your movment speed if you choose this shoe
            CurrentShoe = 1;
            PlayerMovement2D.runSpeed = increaseSpeed;

        }
        else if (Input.GetButton("Shoe2"))
        {
            CurrentShoe = 2;
            PlayerMovement2D.runSpeed = defaultSpeed;
        }
        else if (Input.GetButton("Shoe3"))
        {
            CurrentShoe = 3;
            PlayerMovement2D.runSpeed = defaultSpeed;
        }

    }

}


