    using UnityEngine;

public class AutoCrafting : MonoBehaviour
{
    public PlayerInventory playerInventory;

    // Define the required items and quantities for crafting
    public Item[] requiredItemsForCrafting;

    // Define the crafted item
    public Item craftedItem;

    void Update()
    {
        if (playerInventory.shopping)
        {
            if (CanCraft())
            {
                CraftItem();
            }

        }
    }


    bool CanCraft()
    {
        // Check if player has all required items in the required quantities
        foreach (Item requiredItem in requiredItemsForCrafting)
        {
            if (!playerInventory.HasItem(requiredItem.itemName, requiredItem.quantity))
            {
                return false;
            }
        }
        return true;
    }

    void CraftItem()
    {
        // Remove required items from inventory
        foreach (Item requiredItem in requiredItemsForCrafting)
        {
            playerInventory.RemoveItem(requiredItem.itemName, requiredItem.quantity);
        }

        // Add crafted item to inventory
        playerInventory.AddItem(craftedItem.itemName, craftedItem.quantity);

        Debug.Log($"Crafted {craftedItem.quantity} {craftedItem.itemName}(s)!");
    }
}
