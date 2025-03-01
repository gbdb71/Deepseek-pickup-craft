using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public List<Item> items = new List<Item>();
    public bool shopping = false;

    //Detect collisions between the GameObjects with Colliders attached
    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "Crafting")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log("Do something here");

                shopping = true;
        }
    }
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Crafting")
        {        
            shopping = false;
        }
    }

    
    public void AddItem(string itemName, int quantity)
    {
        Item item = items.Find(i => i.itemName == itemName);
        if (item != null)
        {
            item.quantity += quantity;
        }
        else
        {
            items.Add(new Item(itemName, quantity));
        }
    }

    public bool HasItem(string itemName, int quantity)
    {
        Item item = items.Find(i => i.itemName == itemName);
        return item != null && item.quantity >= quantity;
    }

    public void RemoveItem(string itemName, int quantity)
    {
        Item item = items.Find(i => i.itemName == itemName);
        if (item != null)
        {
            item.quantity -= quantity;
            if (item.quantity <= 0)
            {
                items.Remove(item);
            }
        }
    }
}
