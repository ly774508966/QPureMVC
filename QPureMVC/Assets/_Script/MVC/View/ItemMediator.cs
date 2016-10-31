using UnityEngine;
using System.Collections;
using PureMVC.Patterns;
using PureMVC.Interfaces;
using System.Collections.Generic;
/// <summary>
/// desc 物品Mediator
/// date 2016.10.31
/// auth yuqi
/// </summary>
public class ItemMediator : Mediator, IMediator
{
    public new const string NAME = "ItemMediator";
    private ItemView View { get { return (ItemView)ViewComponent; } }
    // 构造
    public ItemMediator(ItemView v)
        : base(NAME, v)
    {
        Debug.Log("ItemMediator()");
        v.RandomAndRefreshItem += RandomAndRefreshItem;
    }
    #region 按钮点击事件
    //获取一个随机物品
    void RandomAndRefreshItem()
    {
        Debug.Log("点击");
        SendNotification(EventsEnum.GetRandomItem);
        //SendNotification(EventsEnum.GetRandomItem,data);
    }
    #endregion
    #region 消息订阅和处理
    public override IList<string> ListNotificationInterests()
    {
        IList<string> list = new List<string>();
        list.Add(EventsEnum.RefreshItemInfoText);
        return list;
    }
    public override void HandleNotification(INotification notification)
    {
        switch (notification.Name)
        {
            case EventsEnum.RefreshItemInfoText:
                ItemVO item = (ItemVO)notification.Body;
                View.RefreshItemInfoText(item.ItemId + "/" + item.ItemName);
                break;
        }
    }
    #endregion
}
