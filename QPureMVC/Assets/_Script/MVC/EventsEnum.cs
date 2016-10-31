using UnityEngine;
using System.Collections;

public class EventsEnum
{
    //启动消息
    public const string STARTUP = "startup";
    #region 物品模块
    public const string GetRandomItem = "getrandomitem"; //获得随机物品
    public const string RefreshItemInfoText = "refreshiteminfotext"; //刷新物品信息文本
    #endregion
}
