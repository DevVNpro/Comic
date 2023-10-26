using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelPanel : MonoBehaviour
{
    [SerializeField] private Button backMenu;
    [SerializeField] private GameObject buttonSelectLevel;
    [SerializeField] private GameObject content;

    private void Awake()
    {
        backMenu.onClick.AddListener(BackMain);
    }
    private void Start()
    {
        SetUpLevel();
    }
    private void SetUpLevel()
    {
#if UNITY_EDITOR
        ConfigData.SetKeyCurrentPlay(30);
#endif
        for(int i = ConfigData.LevelStart; i <=ConfigData.LevelMax; i++)
        {
            GameObject button = Instantiate(buttonSelectLevel,content.transform);
            content.transform.SetParent(button.transform);
            button.GetComponent<ButtonSelectLevel>().SetUpButton(i);
        }
    }

    private void BackMain()
    {
        RxManager.ClickMain.OnNext(delegate { });
    }
}
