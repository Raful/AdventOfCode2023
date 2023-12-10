using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day10Tile : MonoBehaviour
{
    public event Action OnClicked;

    public bool leadsUp;
    public bool leadsDown;
    public bool leadsLeft;
    public bool leadsRight;

    public void OnTileClicked()
    {
        this.OnClicked?.Invoke();
    }
}
