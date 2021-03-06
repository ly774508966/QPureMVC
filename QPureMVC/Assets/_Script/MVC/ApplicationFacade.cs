﻿using UnityEngine;
using System.Collections;
using PureMVC.Patterns;
using PureMVC.Interfaces;

public class ApplicationFacade : Facade
{
    /// <summary>
    /// Facade Singleton Factory method.  This method is thread safe.
    /// </summary>
    public new static IFacade Instance
    {
        get
        {
            if(m_instance == null)
            {
                lock(m_staticSyncRoot)
                {
                    if (m_instance == null)
                    {
                        //Debug.Log("ApplicationFacade");
                        m_instance = new ApplicationFacade();
                    }
                }
            }
            return m_instance;
        }
    }
    /// <summary>
    /// Start the application
    /// </summary>
    /// <param name="app"></param>
    public void Startup(MainUI mainUI)
    {
        //Debug.Log("Startup() to SendNotification.");
        SendNotification(EventsEnum.STARTUP, mainUI);
    }
    protected ApplicationFacade()
    {
        // Protected constructor.
    }
    /// <summary>
    /// Explicit static constructor to tell C# compiler 
    /// not to mark type as beforefieldinit
    ///</summary>
    static ApplicationFacade()
    {

    }
    // 注册Command消息
    protected override void InitializeController()
    {
        //Debug.Log("InitializeController()");
        base.InitializeController();
        //启动消息
        RegisterCommand(EventsEnum.STARTUP, typeof(StartupCommand));
        //物品消息
        RegisterCommand(EventsEnum.GetRandomItem, typeof(ItemCommand));
    }
}
