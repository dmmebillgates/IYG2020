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
    public float horizontalMove = 10f;
    public bool jump = false;
    public bool crouch = false;
    public bool End = false;
    public bool m_Run = false;

    void Update()
    {
        // Check end position
        if (playerPosition.position.x < stopPosition.position.x - spaceToStop && m_Run) horizontalMove = 1 * runSpeed;
        else horizontalMove = 0 * runSpeed;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        
        // Input's
        if (Input.GetKeyDown(KeyCode.D)) m_Run = true;
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