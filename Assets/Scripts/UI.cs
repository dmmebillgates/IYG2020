using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    // Player
    public PlayerMovement2D Player; // Player positon
    public ShoesSwitcher Shoes; // Current shoe
    public TextMeshProUGUI Message; // Center Message

    // NPC
    public NPC NoPlayerCharacter; // NPC

    // Numbers
    public TextMeshProUGUI DefaultShoe;
    public TextMeshProUGUI HighJumpShoe;
    public TextMeshProUGUI SpeedShoe;
    public TextMeshProUGUI ResizeShoe;
    public TextMeshProUGUI AntiGravityShoe;

    // Private
    private string NewMessage;

    void Start()
    {
        Message.text = "Press [D] to start!";
        NewMessage = $"{NoPlayerCharacter.Name} said: \n\"{NoPlayerCharacter.Message}\"\nPress [E] to back to menu!";
    }

    void Update()
    {
        if (Player.Run) Message.text = string.Empty;
        if (Player.End) Message.text = NewMessage;

        switch (Shoes.CurrentShoe)
        {
            case 1:
                DefaultShoe.color = Color.magenta;
                HighJumpShoe.color = Color.yellow;
                SpeedShoe.color = Color.yellow;
                ResizeShoe.color = Color.yellow;
                AntiGravityShoe.color = Color.yellow;
                break;
            case 2:
                DefaultShoe.color = Color.yellow;
                HighJumpShoe.color = Color.magenta;
                SpeedShoe.color = Color.yellow;
                ResizeShoe.color = Color.yellow;
                AntiGravityShoe.color = Color.yellow;
                break;
            case 3:
                DefaultShoe.color = Color.yellow;
                HighJumpShoe.color = Color.yellow;
                SpeedShoe.color = Color.magenta;
                ResizeShoe.color = Color.yellow;
                AntiGravityShoe.color = Color.yellow;
                break;
            case 4:
                DefaultShoe.color = Color.yellow;
                HighJumpShoe.color = Color.yellow;
                SpeedShoe.color = Color.yellow;
                ResizeShoe.color = Color.magenta;
                AntiGravityShoe.color = Color.yellow;
                break;
            case 5:
                DefaultShoe.color = Color.yellow;
                HighJumpShoe.color = Color.yellow;
                SpeedShoe.color = Color.yellow;
                ResizeShoe.color = Color.yellow;
                AntiGravityShoe.color = Color.magenta;
                break;
        }
    }
}