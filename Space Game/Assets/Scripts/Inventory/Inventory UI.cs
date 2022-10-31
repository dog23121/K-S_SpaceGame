using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    private bool _inUI = false;

    public bool inUI
    {
        get { return _inUI; }
        
        set
        {
            _inUI = value;
        }
    }

}
