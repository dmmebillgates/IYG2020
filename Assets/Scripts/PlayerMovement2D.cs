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
    public bool Run = false;
    public bool End = false;

    void Start() => Cursor.visible = false; // Hide cursor

    void Update()
    {
        // Check end position
        if (GetComponent<Transform>().position.x <= stopPosition.position.x - spaceToStop && Run)
            HorizontalMove = 1 * RunSpeed;
        else
        {
            HorizontalMove = 0 * RunSpeed;
        }

        // Switch end to true
        if (GetComponent<Transform>().position.x > stopPosition.position.x - spaceToStop) End = true;

        // Animations
        animator.SetFloat("Speed", Mathf.Abs(HorizontalMove));

        // Input's
        if (Input.GetKeyDown(KeyCode.D)) Run = true;
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