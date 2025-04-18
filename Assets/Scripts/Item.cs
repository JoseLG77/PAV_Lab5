using UnityEngine;

public enum TypeOfItem
{
    none,
    Armor,
    Weapon,
    Consumable,
    Enchansment
}

public class Item
{
    private TypeOfItem typeOfItem = TypeOfItem.none;
    private string itemName = "";

    public TypeOfItem TypeOfItem => typeOfItem;
    public string ItemName => itemName;

    public Item(string _itemName)
    {
        typeOfItem = TypeOfItem.none;
        itemName = _itemName;
    }

    public Item(TypeOfItem _typeOfItem, string _itemName)
    {
        typeOfItem = _typeOfItem;
        itemName = _itemName;
    }

    public void SetType(TypeOfItem _typeOfItem)
    {
        typeOfItem = _typeOfItem;
    }
}
