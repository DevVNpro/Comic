using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

public class RxManager : MonoBehaviour
{
    #region UI
    public static readonly Subject<Action> OpenLevelPanel = new Subject<Action>();
    public static readonly Subject<Action> OpenMain = new Subject<Action>();
    public static readonly Subject<Action> OpenSetting = new Subject<Action>();
    #endregion
    #region gameplay
    #endregion
}
