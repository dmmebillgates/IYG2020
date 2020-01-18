using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    public PlayerMovement2D player; // Player positon
    public ShoesSwitcher shoes; // Current shoe
    public TextMeshProUGUI messages; // Center Message

    // Numbers
    public TextMeshProUGUI DefaultShoe;
    public TextMeshProUGUI HighJumpShoe;
    public TextMeshProUGUI SpeedShoe;
    public TextMeshProUGUI ResizeShoe;
    public TextMeshProUGUI AntiGravityShoe;
    

    void Update()
    {
        if (player.Run) messages.text = string.Empty;
        if (player.End) messages.text = "Press 'E' to back to main menu!";

        switch (shoes.CurrentShoe)
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