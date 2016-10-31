using UnityEngine;
using System.Collections;
/// <summary>
/// desc 物品VO
/// date 2016.10.31
/// auth yuqi
/// </summary>
public class ItemVO
{
    private int itemId;
    private string itemName;

    public int ItemId { get { return itemId; } }
    public string ItemName { get { return itemName; } }
    
    public ItemVO(int itemId, string itemName)
    {
        this.itemId = itemId;
        this.itemName = itemName;
    }
}
