using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelPanel : MonoBehaviour
{
    [SerializeField] private Button backMenu;

    private void Awake()
    {
        backMenu.onClick.AddListener(BackMain);
    }
    private void BackMain()
    {
        RxManager.ClickMain.OnNext(delegate { });
    }
}
