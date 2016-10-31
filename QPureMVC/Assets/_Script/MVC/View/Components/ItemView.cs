using UnityEngine;
using System.Collections;
using UnityEngine.UI;
/// <summary>
/// desc 物品界面
/// date 2016.10.31
/// auth yuqi
/// </summary>
public class ItemView : MonoBehaviour {
    //控件
    public Text itemInfo_t;
    public Button item_btn;
    //Action
    public System.Action RandomAndRefreshItem;
    void Start()
    {
        // 添加按钮点击事件
        Utils.AddBtnClick(item_btn, RandomAndRefreshItem);
    }

    #region 提供方法
    public void RefreshItemInfoText(string txt)
    {
        itemInfo_t.text = txt;
    }
    #endregion 
}
