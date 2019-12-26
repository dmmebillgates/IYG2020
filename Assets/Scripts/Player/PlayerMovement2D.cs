using UnityEngine;

public class PlayerMovement2D : MonoBehaviour
{
    // Set in unity
    public CharacterController2D controller;
    public float runSpeed = 100f;
    public Animator animator;

    public Transform playerPosition;
    public Transform stopPosition;
    public int spaceToStop;

    // Default values
    float horizontalMove = 10f;
    bool jump = false;
    bool crouch = false;

    void Update()
    {
        if (playerPosition.position.x < stopPosition.position.x - spaceToStop)
        {
            horizontalMove = 1 * runSpeed;
        }
        else
        {
            horizontalMove = 0 * runSpeed;
        }

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButton("Jump"))
        {
            jump = true;
            animator.SetBool("IsJumping", true);
        }
    }
    public void Landing()
    {
        animator.SetBool("IsJumping", false);
    }
    void FixedUpdate()
    {

        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;

    }
}
