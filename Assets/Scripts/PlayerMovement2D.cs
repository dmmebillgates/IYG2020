using UnityEngine;

public class PlayerMovement2D : MonoBehaviour
{
    // Set in unity
    public CharacterController2D controller;
    public float runSpeed = 100f;
    
    // Default values
    float horizontalMove = 10f;
    bool jump = false;

    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        if (Input.GetButton("Jump"))
        {
            jump = true;
        }
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
