using UnityEngine;
using System.Collections;
public class MainUI : MonoBehaviour
{
    // 绑定视图组件
    public ItemView itemView;
    void Awake()
    {
        ApplicationFacade facade = ApplicationFacade.Instance as ApplicationFacade;
        facade.Startup(this);
    }
}
