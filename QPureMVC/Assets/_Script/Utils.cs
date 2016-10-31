using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Utils
{
    public static void AddBtnClick(Button btn, System.Action action)
    {
        btn.onClick.AddListener(() => { if (action != null) action(); });
    }
}
