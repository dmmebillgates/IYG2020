using UnityEngine;

public class PlayerMovement2D : MonoBehaviour
{
    // Set in unity
    public CharacterController2D controller;
    public Transform stopPosition;
    public Animator animator;
    public float RunSpeed = 100f;
    public float spaceToStop = 1f;

    // Default values
    public float HorizontalMove = 10f;
    public bool Jump = false;
    private bool m_End = false;
    private bool m_Run = false;

    void Update()
    {
        // Check end position
        if (GetComponent<Transform>().position.x < stopPosition.position.x - spaceToStop && m_Run)
            HorizontalMove = 1 * RunSpeed;
        else HorizontalMove = 0 * RunSpeed;
        animator.SetFloat("Speed", Mathf.Abs(HorizontalMove));

        // Input's
        if (Input.GetKeyDown(KeyCode.D)) m_Run = true;
        if (Input.GetButton("Jump"))
        {
            Jump = true;
            animator.SetBool("IsJumping", true);
        }
    }

    void FixedUpdate()
    {
        controller.Move(HorizontalMove * Time.fixedDeltaTime, false, Jump);
        Jump = false;
    }

    public void Landing() => animator.SetBool("IsJumping", false);
}