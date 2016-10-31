using PureMVC.Patterns;
using PureMVC.Interfaces;
/// <summary>
/// desc 物品控制器
/// date 2016.10.31
/// auth yuqi
/// </summary>
public class ItemCommand : SimpleCommand, ICommand
{
    public override void Execute(INotification notification)
    {
        ItemProxy itemProxy = (ItemProxy)Facade.RetrieveProxy(ItemProxy.NAME);
        switch (notification.Name)
        {
            case EventsEnum.GetRandomItem:
                ItemVO rdItem = itemProxy.GetRandomItem();
                SendNotification(EventsEnum.RefreshItemInfoText,rdItem);
                break;
        }
    }
}
