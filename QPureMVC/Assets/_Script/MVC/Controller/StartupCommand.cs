using UnityEngine;
using System.Collections;
using PureMVC.Patterns;
using PureMVC.Interfaces;

public class StartupCommand : SimpleCommand, ICommand
{
    public override void Execute(INotification notification)
    {
        // 注册Proxy
        Facade.RegisterProxy(new ItemProxy());
        // 绑定视图和Mediator
        MainUI mainUI = notification.Body as MainUI;
        Facade.RegisterMediator(new ItemMediator(mainUI.itemView));
    }


}
