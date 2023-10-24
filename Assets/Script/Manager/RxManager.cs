using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

public abstract class RxManager : MonoBehaviour
{
    #region UI
    public static readonly Subject<Action> ClickLevelPanel = new Subject<Action>();
    public static readonly Subject<Action> ClickMain = new Subject<Action>();
    public static readonly Subject<Action> ClickSetting = new Subject<Action>();
    #endregion
    #region gameplay
    public static readonly Subject<Action> ButtonWin = new Subject<Action>();
    public static readonly Subject<Action> ButtonLosse = new Subject<Action>();
    #endregion
}
