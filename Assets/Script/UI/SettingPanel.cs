using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingPanel : MonoBehaviour
{
    [Header("Button")]
    [SerializeField] private Button buttonBack;
    private void Awake()
    {
        buttonBack.onClick.AddListener(BackMain);
    }
    private void BackMain()
    {
        RxManager.ClickMain.OnNext(delegate { });
    }
}
