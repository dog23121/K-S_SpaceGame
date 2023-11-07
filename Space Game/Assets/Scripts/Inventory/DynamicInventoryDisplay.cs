using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DynamicInventoryDisplay : InventoryDisplay
{
 
    [SerializeField] protected InventorySlotUi slotPrefab;
    protected override void Start()
    {
        base.Start();

        
    }



    public void RefreshDynamicInventory(InventorySystem invTodisplay)
    {
        ClearSlots();
        inventorySystem = invTodisplay;
        AssignSlot(invTodisplay);
    }

    public override void AssignSlot(InventorySystem invToDisplay)
    {
        slotDictionary = new Dictionary<InventorySlotUi, InventorySlot>();

        if (invToDisplay == null) return;

        for (int i = 0; i < invToDisplay.InventorySize; i++)
        {
            var uiSlot = Instantiate(slotPrefab, transform);
            slotDictionary.Add(uiSlot, invToDisplay.InventorySlots[i]);
            uiSlot.Init(invToDisplay.InventorySlots[i]);
            uiSlot.UpdateUISlot();
        }
    }

    private void ClearSlots()
    {
        foreach (var item in transform.Cast<Transform>())
        {
            Destroy(item.gameObject);
        }

        if (SlotDictionary != null) slotDictionary.Clear();
        {

        }
    }
}
