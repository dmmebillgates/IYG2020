using UnityEngine;

public class ShoesSwitcher : MonoBehaviour
{
    public PlayerMovement2D PlayerMovement2D;
    public int CurrentShoe = 1;

    // Default values
    public Vector2 DefaultSize = new Vector2(1f, 1f);
    public int DefaultGravityScale = 3;
    public int DefaultSpeed = 25;
    private bool m_Smaller;

    // Increase values
    public Vector2 SmallSize = new Vector2(0.5f, 0.5f);
    public int IncreasedGravityScale = 1;
    public int IncreasedSpeed = 50;

    void Update()
    {
        Debug.Log($"Current shoes: {CurrentShoe}");
        if (Input.GetButtonUp("Shoe1"))
        {
            // Default shoes nothing increase 
            CurrentShoe = 1;

            if (m_Smaller) Jump();

            PlayerMovement2D.RunSpeed = DefaultSpeed;
            transform.localScale = DefaultSize;
            GetComponent<Rigidbody2D>().gravityScale = DefaultGravityScale;
        }
        else if (Input.GetButtonUp("Shoe2"))
        {
            // Higher Jump
            CurrentShoe = 2;

            if (m_Smaller) Jump();

            PlayerMovement2D.RunSpeed = DefaultSpeed;
            GetComponent<Rigidbody2D>().gravityScale = IncreasedGravityScale;
            transform.localScale = DefaultSize;
        }
        else if (Input.GetButtonUp("Shoe3"))
        {
            // Increases your movement speed
            CurrentShoe = 3;

            if (m_Smaller) Jump();

            PlayerMovement2D.RunSpeed = IncreasedSpeed;
            transform.localScale = DefaultSize;
            GetComponent<Rigidbody2D>().gravityScale = DefaultGravityScale;
        }
        else if (Input.GetButtonUp("Shoe4"))
        {
            // Reduces size of the player
            CurrentShoe = 4;
            m_Smaller = true;

            // Transform
            if (!m_Smaller)
                GetComponent<Transform>().position = new Vector2(GetComponent<Transform>().position.x,
                    GetComponent<Transform>().position.y + 1);

            // Jump
            PlayerMovement2D.Jump = true;
            PlayerMovement2D.animator.SetBool("IsJumping", true);

            PlayerMovement2D.RunSpeed = DefaultSpeed;
            transform.localScale = SmallSize;
            GetComponent<Rigidbody2D>().gravityScale = DefaultGravityScale;
        }
        else if (Input.GetButtonUp("Shoe5"))
        {
            // Flip player upside down
            CurrentShoe = 5;

            if (m_Smaller) Jump();

            PlayerMovement2D.RunSpeed = DefaultSpeed;
            transform.localScale = DefaultSize;
            GetComponent<Rigidbody2D>().gravityScale = -DefaultGravityScale;
            GetComponent<Rigidbody2D>().transform.localScale = new Vector3(1, -1, 1);
        }
    }

    public void Jump()
    {
        float transformY = GetComponent<Transform>().position.y + 0.5f;
        GetComponent<Transform>().position = new Vector2(GetComponent<Transform>().position.x, transformY);
        m_Smaller = false;
    }
}