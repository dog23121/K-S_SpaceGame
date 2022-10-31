using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Inventory : MonoBehaviour, IPointerDownHandler
{
    public void OnPointerDown(PointEventData eventData)
    {
        Debug.Log("OnPointerDown");
    }


}
