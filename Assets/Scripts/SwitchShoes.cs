using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchShoes : MonoBehaviour
{
    public PlayerMovement2D PlayerMovement2D;
    public int CurrentShoe;
    void Update()
    {
        if (Input.GetButton("Shoe0"))
        {
            CurrentShoe = 0;
        }
        if (Input.GetButton("Shoe1"))
        {
            CurrentShoe = 1;
        }
        if (Input.GetButton("Shoe2"))
        {
            CurrentShoe = 2;
        }
        if (Input.GetButton("Shoe3"))
        {
            CurrentShoe = 3;
        }

    }

}


