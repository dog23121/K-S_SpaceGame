using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvUI : MonoBehaviour
{

    public GameObject inventory;
    public bool invOpen;

    void Update()
    {



        if (invOpen == false && Input.GetKeyDown(KeyCode.E))
        {
            inventory.SetActive(true);
            invOpen = true;
        }
    }

}
