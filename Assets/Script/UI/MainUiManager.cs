using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class MainUiManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject LevelPanel;
    public GameObject mainPanel;
    public GameObject SetingPanel;
    public List<GameObject> popup;
    void Start()
    {
        RxManager.OpenMain.Subscribe(delegate (Action action)
        {
            CloseAllPanel();
            ActiveHomePanel();
        }).AddTo(this);
        RxManager.OpenLevelPanel.Subscribe(delegate (Action action)
        {
            CloseAllPanel();
            ActiveLevelPanel(); 
        }).AddTo(this);
        RxManager.OpenSetting.Subscribe( _ =>
        {
            CloseAllPanel();
            AtiveSettingPanel();
        }).AddTo(this);
    }
    private void ActiveLevelPanel()
    {
 
            CloseAllPanel();
        LevelPanel.SetActive(true);
       
    }
    private void ActiveHomePanel()
    {
        CloseAllPanel();
        mainPanel.SetActive(true);
    }
    private void AtiveSettingPanel()
    {
        CloseAllPanel();
        SetingPanel.gameObject.SetActive(true);
    }
    public void ActivePopup()
    {
        foreach(var a in popup)
        {

        }

    }
    public void CloseAllPanel()
    {
        foreach(var a in popup)
        {
            a.SetActive(false);
        }
    }    
    
}
