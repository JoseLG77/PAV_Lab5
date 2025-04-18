using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    private Dictionary<Item, int> inventory = new Dictionary<Item, int>();

    public void Add(Item _item)
    {
        if (inventory.ContainsKey(_item))
        {
            inventory.TryGetValue(_item, out int value);
            int tempValue = value;

            inventory[_item] = tempValue;
        }
        else
            inventory.Add(_item, 1);
    }

    public void Add(Item _item, TypeOfItem _typeOfItem)
    {
        _item.SetType(_typeOfItem);
        Add(_item);
    }

    public void Add(Item _item, int quantity)
    {
        if (inventory.ContainsKey(_item))
            {
                inventory.TryGetValue(_item, out int value);
                int tempValue = value + quantity;

                inventory[_item] = tempValue;
        }
        else
            inventory.Add(_item, quantity);
    }

    public void Add(Item _item, TypeOfItem _typeOfItem, int quantity)
    {
        _item.SetType(_typeOfItem);
        Add(_item, quantity);
    }

    public void ShowAllItems()
    {
        foreach (var slot in inventory)
        {
            Debug.Log($"El item {slot.Key.ItemName} con la cantidad {slot.Value}");
        }
    }

}
