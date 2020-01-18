
using TMPro;
using UnityEngine;

public class UIMessages : MonoBehaviour
{
    public TextMeshProUGUI messages;
    public PlayerMovement2D player;
    
    void Update()
    {
        if (player.m_Run) messages.text = "";
    }
}
