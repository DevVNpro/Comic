using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UnityEngine.UI;

public class HomePanel : MonoBehaviour
{
    [Space(15)]
    [SerializeField] private Button buttonSellectLevel;
    [SerializeField] private Button buttonSetting;
    private void Awake()
    {
        buttonSellectLevel.onClick.AddListener(OpenSelectLevel);
        buttonSetting.onClick.AddListener(OpenSettingPanel);
    }
    public void OpenSelectLevel()
    {
        RxManager.OpenLevelPanel.OnNext(delegate { });
    }
    public void OpenSettingPanel()
    {
        RxManager.OpenSetting.OnNext(delegate { });
    }

}
