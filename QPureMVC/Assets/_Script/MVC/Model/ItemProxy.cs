using UnityEngine;
using System.Collections;
using PureMVC.Patterns;
using PureMVC.Interfaces;
using System.Collections.Generic;
/// <summary>
/// desc 物品数据
/// date 2016.10.31
/// auth yuqi
/// </summary>
public class ItemProxy : Proxy,IProxy {
    public new const string NAME = "ItemProxy";
    public IList<ItemVO> Items 
    {
        get { return (IList<ItemVO>)base.Data; }
    }
    //构造
    public ItemProxy()
        : base(NAME,new List<ItemVO>())
    {
        Debug.Log("ItemProxy");
        Items.Add(new ItemVO(0, "物品0"));
        Items.Add(new ItemVO(1, "物品1"));
        Items.Add(new ItemVO(2, "物品2"));
    }
    #region 提供方法
    public ItemVO GetRandomItem() {
        return Items[Random.Range(0, 3)];
    }
    #endregion
}
