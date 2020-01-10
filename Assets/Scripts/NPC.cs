using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public string npcName;
    public Dialog dialogManager;
    public List<string> npcConvo = new List<string>();

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            dialogManager.Start_Dialog(npcName, npcConvo);
            
        }
    }

}
