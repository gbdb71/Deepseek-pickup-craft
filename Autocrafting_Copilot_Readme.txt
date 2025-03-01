To use this script, you need to attach the PlayerInventory and AutoCrafting scripts to a GameObject in your Unity scene. You can then define the required items and the crafted item in the Unity Inspector.

    Create an empty GameObject in your scene and name it "Player".
    Attach the PlayerInventory script to the "Player" GameObject.
    Create another empty GameObject in your scene and name it "Crafting".
    Attach the AutoCrafting script to the "Crafting" GameObject.
    In the Unity Inspector, set the Player Inventory field of the AutoCrafting script to reference the "Player" GameObject.
    Define the required items for crafting and the crafted item in the Unity Inspector.

This setup will automatically craft the specified item when the player has the required quantities of the specified items in their inventory.
